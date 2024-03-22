using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using MathNet.Numerics.LinearAlgebra.Complex32;
using MathNet.Numerics.Interpolation;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace ShakeTableGUI.UserControls
{
    public partial class PostProcessing : UserControl
    {
        public PostProcessing()
        {
            InitializeComponent();
        }

        public (double[], double[], double[]) NewmarksAcceleration(double[] at)
        {
            // Get maximum and minimum period
            double max_period = double.Parse(max_period_text.Text);

            // Assume values for mass
            double m = 1.0;

            // Calculate the start and end indices of the range
            int start = 0;
            int end = (int)Math.Round(m / Math.Pow(max_period / (2.0 * Math.PI), 2));

            // Create a stiffness array to vary the time steps
            double[] k = Enumerable.Range(start, end - start + 1).Select(x => 0.01).ToArray();

            // Get gamma and beta value for Newmarks Method (Average or Linear)
            double beta = double.Parse(beta_text.Text);
            double gamma = double.Parse(gamma_text.Text);

            Console.WriteLine(beta);
            Console.WriteLine(gamma);

            // Get Target Damping Ratio
            double xi = double.Parse(damping_ratio.Text);

            // Calculate damping coefficient
            double[] c = k.Select(stiff => 2 * xi * Math.Sqrt(m * stiff)).ToArray();

            // Calculate the ground excitation
            double[] pt = at.Select(accl => accl * m).ToArray();

            // Get the length of ground excitation
            int N = pt.Length;


            // Get the length of mass matrix
            int M = k.Length;

            // Initialize u, uv, ua max
            double[] u_max = new double[M];
            double[] uv_max = new double[M];
            double[] ua_max = new double[M];


            for (int j = 0; j < M; j++)
            {
                // Initialize u, uv, ua
                double[] u = new double[N];
                double[] uv = new double[N];
                double[] ua = new double[N];

                // Fill in the initial conditions of u0 and uv0
                u[0] = 0;
                uv[0] = 0;

                // Initial Calculation
                // 1.1 Calculate ua0
                ua[0] = (pt[0] - c[0] * uv[0] - k[0] * u[0]) / m;

                // 1.2 Select dt
                float dt = float.Parse(period_step.Text);
                // 1.3 khat
                double k_hat = k[j] + gamma / (beta * dt) * c[j] + 1 / (beta * Math.Pow(dt, 2)) * m;
                // 1.4 Calculate a and b
                double a = 1 / (beta * dt) * m + gamma / beta * c[j];
                double b = 1 / (2 * beta) * m + dt * (gamma / (2 * beta) - 1) * c[j];

                // Calculate for each time step
                double[] dp_hat = new double[N];
                double[] du = new double[N - 1];
                double[] dv = new double[N - 1];
                double[] da = new double[N - 1];

                for (int i = 0; i < N - 1; i++)
                {
                    // 2.1 Calculate delta phat
                    dp_hat[i] = (pt[i + 1] - pt[i]) + a * uv[i] + b * ua[i];

                    // 2.2 Calculate delta ui
                    du[i] = dp_hat[i] / k_hat;

                    // 2.3 Calculate delta vi
                    dv[i] = gamma / (beta * dt) * du[i] - gamma / beta * uv[i] + dt * (1 - gamma / (2 * beta)) * ua[i];

                    // 2.4 Calculate delta ai
                    da[i] = 1 / (beta * Math.Pow(dt, 2)) * du[i] - 1 / (beta * dt) * uv[i] - 1 / (2 * beta) * ua[i];

                    // Update u, uv, ua
                    u[i + 1] = u[i] + du[i];
                    uv[i + 1] = uv[i] + dv[i];
                    ua[i + 1] = ua[i] + da[i];
                }

                // Find the maximum absolute values
                u_max[j] = u.Select(Math.Abs).Max();
                uv_max[j] = uv.Select(Math.Abs).Max();
                ua_max[j] = ua.Select(Math.Abs).Max();

            }

            return (u_max, uv_max, ua_max);
        }

        private void exportRS_butt_Click(object sender, EventArgs e)
        {
            // Create save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Export Data";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name
                string fileName = saveFileDialog.FileName;

                //// Write data to the file
                //using (StreamWriter sw = new StreamWriter(fileName))
                //{
                //    // Write column headers
                //    sw.WriteLine("Index,Array 1,Array 2,Array 3");

                //    // Write data rows
                //    for (int i = 0; i < array1.Length; i++)
                //    {
                //        sw.WriteLine($"{i},{array1[i]},{array2[i]},{array3[i]}");
                //    }
                //}

                MessageBox.Show("Data exported successfully!", "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void Import_RS_but_Click(object sender, EventArgs e)
        {
            // Open the File Dialog to read in a file
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browser File",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*\"",
                FilterIndex = 1,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };

            // Show text from the file in the DataGrid
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RS_TB.Text = openFileDialog1.FileName;
                ImportHelper.file = RS_TB.Text;
            }

            List<double> RS_accelData = new List<double>();

            // Read the file line by line
            using (StreamReader reader = new StreamReader(RS_TB.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into columns
                    string[] columns = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    // Check if there are at least two columns and if the second column is a valid double
                    if (columns.Length >= 2 && double.TryParse(columns[1], out double value))
                    {
                        RS_accelData.Add(value); // Add the second column value to the list
                    }
                    else
                    {
                        // Handle invalid data or empty lines
                        Console.WriteLine("Invalid data or empty line: " + line);
                    }
                }
            }

            // Convert the list to an array if necessary
            double[] RS_accelArray = RS_accelData.ToArray();

            (double[] u_max, double[] uv_max, double[] ua_max) = NewmarksAcceleration(RS_accelArray);
            string type_label = RS_type_box.Text;

            if (type_label == "Acceleration Response Spectrum")
            {
                plotRS(ua_max, type_label);
            }
            if (type_label == "Velocity Response Spectrum")
            {
                plotRS(uv_max, type_label);
            }
            if (type_label == "Displacement Response Spectrum")
            {
                plotRS(u_max, type_label);
            }

        }

        private void Import_FFT_but_Click(object sender, EventArgs e)
        {
            // Open the File Dialog to read in a file
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browser File",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*\"",
                FilterIndex = 1,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };

            // Show path of file path
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FFT_TB.Text = openFileDialog1.FileName;
                ImportHelper.file = FFT_TB.Text;
            }

            (double[] timeData, double[] accelerationData) = read_time_accl(FFT_TB.Text);
            double dt = 0.001;
            Complex[] fftResult = FFT_Result(timeData, accelerationData, dt);

            // Add columns to the DataGridView
            FFT_result_DG.Columns.Add("Frequency", "Frequency (Hz)");
            FFT_result_DG.Columns.Add("Magnitude", "Magnitude");

            // Populate the DataGridView with frequency and magnitude data
            for (int i = 0; i < fftResult.Length; i++)
            {
                // Calculate frequency corresponding to the FFT bin
                double frequency = Math.Round(i / (double)fftResult.Length, 4);

                // Add a new row with frequency and magnitude data
                FFT_result_DG.Rows.Add(frequency, fftResult[i].Magnitude);
            }

            plot_FFT();


        }

        private Complex[] FFT_Result(double[] timeData, double[] accelerationData, double dt)
        {
            // Resample data onto a uniform grid
            double[] uniformTimeGrid = GenerateUniformTimeGrid(timeData, dt);
            double[] uniformAccelerationData = ResampleData(timeData, accelerationData, uniformTimeGrid);

            // Convert resampled acceleration data to Complex32[] array
            Complex32[] complexAccelerationData = new Complex32[uniformAccelerationData.Length];
            for (int i = 0; i < uniformAccelerationData.Length; i++)
            {
                complexAccelerationData[i] = new Complex32((float)uniformAccelerationData[i], 0);
            }

            // Perform FFT on resampled data
            Fourier.Forward(complexAccelerationData);

            // Convert Complex32[] to Complex[]
            Complex[] fftResult = new Complex[complexAccelerationData.Length];
            for (int i = 0; i < complexAccelerationData.Length; i++)
            {
                fftResult[i] = new Complex(complexAccelerationData[i].Real, complexAccelerationData[i].Imaginary);
            }

            return fftResult;
        }

        // Generate a uniform time grid based on the time step (dt)
        private double[] GenerateUniformTimeGrid(double[] timeData, double dt)
        {
            List<double> uniformTimeGrid = new List<double>();
            double startTime = timeData[0];
            double endTime = timeData[timeData.Length - 1];

            for (double t = startTime; t <= endTime; t += dt)
            {
                uniformTimeGrid.Add(t);
            }

            return uniformTimeGrid.ToArray();
        }

        // Resample data onto a uniform grid using linear interpolation
        private double[] ResampleData(double[] timeData, double[] originalData, double[] uniformTimeGrid)
        {
            // Use linear interpolation to resample data onto uniform grid
            IInterpolation interpolation = Interpolate.Linear(timeData, originalData);
            double[] resampledData = new double[uniformTimeGrid.Length];
            for (int i = 0; i < uniformTimeGrid.Length; i++)
            {
                resampledData[i] = interpolation.Interpolate(uniformTimeGrid[i]);
            }
            return resampledData;
        }

        private (double[], double[]) read_time_accl(string filePath)
        {
            // Read data from file
            List<double> timeData = new List<double>();
            List<double> accelerationData = new List<double>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('\t'); // Assuming tab-separated data, adjust if necessary

                    if (parts.Length >= 2 && double.TryParse(parts[0], out double time) && double.TryParse(parts[1], out double acceleration))
                    {
                        timeData.Add(time);
                        accelerationData.Add(acceleration);
                    }
                    else
                    {
                        Console.WriteLine("Invalid data format in line: " + line);
                    }
                }
            }

            // Convert lists to arrays
            double[] timeArray = timeData.ToArray();
            double[] accelerationArray = accelerationData.ToArray();


            return (timeArray, accelerationArray);
        }

        private void plot_FFT()
        {
            // Initialize the chart
            FFT_chart.Series.Clear();


            // Extract data from DataGridView and plot into Line Chart
            foreach (DataGridViewColumn column in FFT_result_DG.Columns)
            {
                // Extract X and Y values from DataGridView and plot into Line Chart
                FFT_chart.Series.Clear();

                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 2;

                foreach (DataGridViewRow row in FFT_result_DG.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        double xValue, yValue;
                        if (double.TryParse(row.Cells[0].Value.ToString(), out xValue) && double.TryParse(row.Cells[1].Value.ToString(), out yValue))
                        {
                            series.Points.AddXY(xValue, yValue);
                        }
                    }
                }

                FFT_chart.Series.Add(series);

                // X and Y axies title
                FFT_chart.ChartAreas[0].AxisX.Title = "Frequency (Hz)";
                FFT_chart.ChartAreas[0].AxisY.Title = "Magnitude";

                // Increase font size of the axis titles
                FFT_chart.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft San Serif", 12f);
                FFT_chart.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft San Serif", 12f);
            }


        }

        private void plotRS(double[] yValues, string label)
        {
            // Initialize the chart
            RS_chart.Series.Clear();

            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;

            // Add data to the series
            for (int i = 0; i < yValues.Length; i++)
            {
                series.Points.AddXY(i * 0.01, yValues[i]); // Assuming a timestep of 0.01
            }

            RS_chart.Series.Add(series);

            // X and Y axies title
            RS_chart.ChartAreas[0].AxisX.Title = "Period (s)";
            if(label == "Acceleration Response Spectrum")
            {
                RS_chart.ChartAreas[0].AxisY.Title = "Acceleration (g)";
            }
            else if (label == "Velocity Response Spectrum")
            {
                RS_chart.ChartAreas[0].AxisY.Title = "Velocity (mm/s)";
            }
            else if (label == "Displacement Response Spectrum")
            {
                RS_chart.ChartAreas[0].AxisY.Title = "Displacement (mm)";
            }


            // Increase font size of the axis titles
            RS_chart.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft San Serif", 12f);
            RS_chart.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft San Serif", 12f);

        }
    }
}
