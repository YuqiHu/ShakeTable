using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ResponseSpectrumAnalysis;


namespace ShakeTableGUI.UserControls
{
    public partial class PostProcessing : UserControl
    {
        double[] Tn;
        double[] u_max;
        double[] uv_max;
        double[] ua_max;

        double[] RS_accelArray;

        public PostProcessing()
        {
            InitializeComponent();
        }

        #region Response_Spectrum
        
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

                // Write data to the file
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    string type_label = RS_type_box.Text;
                    if (type_label == "Acceleration Response Spectrum")
                    {
                        writeFile(sw, "Period(s)", "Displacement(m)", Tn, u_max);
                    }
                    if (type_label == "Velocity Response Spectrum")
                    {
                        writeFile(sw, "Period(s)", "Displacement(m)", Tn, uv_max);
                    }
                    if (type_label == "Displacement Response Spectrum")
                    {
                        writeFile(sw, "Period(s)", "Displacement(m)", Tn, ua_max);
                    }                    
                }

                MessageBox.Show("Data exported successfully!", "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void writeFile(StreamWriter sw, string header1, string header2, double[] time, double[] y)
        {
            sw.WriteLine($"{header1}\t{header2}");

            if (time.Length != y.Length)
                throw new ArgumentException("Lists are not in the same length");

            // Write data rows
            for (int i = 0; i < time.Length; i++)
            {
                sw.WriteLine($"{time[i]}\t{y[i]}");
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

                RS_accelArray = RS_accelData.ToArray();
            }
        }

        #endregion

        #region FFT
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

            // read data from the file and show in the table beside
            double[] time = ReadDataFromFile(FFT_TB.Text, Delimitor_Text.Text, 0);
            double[] accl = ReadDataFromFile(FFT_TB.Text, Delimitor_Text.Text, 1);

            // Combine the arrays into a DataTable
            DataTable table = CombineDataIntoDataTable(time, accl);

            // Display the data in the DataGridView
            DisplayDataInDataGridView(table);

            // Sampling period and frequency
            double T = 20e-3;  // Sampling period
            double Fs = 1 / T; // Sampling frequency

            // Perform NUFFT
            //double[] Y = NUFFT.Nufft(accl, time.Select(t => t / T).ToArray(), null, 1);

            // Compute frequency axis
            int n = time.Length;
            double[] f = Enumerable.Range(0, n).Select(i => i / (double)n * Fs).ToArray();

            Console.WriteLine(f.Length);
            //Console.WriteLine(Y.Length);

            // plot_FFT();
            // plot_FFT(f, Y);

        }



        // Function to read the file and parse the data
        static double[] ReadDataFromFile(string filePath, string delimiter, int columnIndex)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                // Extract data for the specified column
                double[] columnData = lines
                    .Select(line => line.Split(new string[] { delimiter }, StringSplitOptions.None)[columnIndex])
                    .Select(value => double.Parse(value))
                    .ToArray();

                return columnData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return new double[0];
            }
        }

        private DataTable CombineDataIntoDataTable(double[] column1Data, double[] column2Data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Column1", typeof(double));
            table.Columns.Add("Column2", typeof(double));

            int rowCount = Math.Min(column1Data.Length, column2Data.Length);
            for (int i = 0; i < rowCount; i++)
            {
                table.Rows.Add(column1Data[i], column2Data[i]);
            }

            return table;
        }

        private void DisplayDataInDataGridView(DataTable table)
        {
            // Bind the DataTable to the DataGridView
            FFT_result_DG.DataSource = table;
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

        //private void plot_FFT(double[] frequencies, double[] magnitudes)
        //{
        //    // Check if arrays are not null and have the same length
        //    if (frequencies == null || magnitudes == null)
        //    {
        //        MessageBox.Show("Data arrays are null.");
        //        return;
        //    }

        //    if (frequencies.Length != magnitudes.Length)
        //    {
        //        MessageBox.Show("Data arrays have different lengths.");
        //        return;
        //    }

        //    if (frequencies.Length == 0)
        //    {
        //        MessageBox.Show("Data arrays are empty.");
        //        return;
        //    }

        //    // Initialize the chart
        //    FFT_chart.Series.Clear();

        //    // Create a new series for the FFT plot
        //    var series = new System.Windows.Forms.DataVisualization.Charting.Series
        //    {
        //        ChartType = SeriesChartType.Line,
        //        BorderWidth = 2
        //    };

        //    // Add data points to the series
        //    for (int i = 0; i < frequencies.Length; i++)
        //    {
        //        // Ensure that indices are within bounds
        //        if (i < frequencies.Length && i < magnitudes.Length)
        //        {
        //            series.Points.AddXY(frequencies[i], Math.Abs(magnitudes[i]));
        //        }
        //        else
        //        {
        //            MessageBox.Show($"Index {i} is out of range.");
        //            break;
        //        }
        //    }

        //    // Add the series to the chart
        //    FFT_chart.Series.Add(series);

        //    // X and Y axes title
        //    FFT_chart.ChartAreas[0].AxisX.Title = "Frequency (Hz)";
        //    FFT_chart.ChartAreas[0].AxisY.Title = "Magnitude";

        //    // Increase font size of the axis titles
        //    FFT_chart.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft Sans Serif", 12f);
        //    FFT_chart.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft Sans Serif", 12f);
        //}



        #endregion

        private void plotRS(double[] xValues, double[] yValues, string label)
        {
            // Initialize the chart
            RS_chart.Series.Clear();

            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;

            // Add data to the series
            for (int i = 1; i < yValues.Length; i++)
            {
                series.Points.AddXY(xValues[i], yValues[i]); // Assuming a timestep of 0.01
            }

            // Add the series to the chart
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


            // Rescale X and Y axes
            RS_chart.ChartAreas[0].AxisX.Minimum = xValues.Min();
            RS_chart.ChartAreas[0].AxisX.Maximum = xValues.Max(); 
            RS_chart.ChartAreas[0].AxisX.Interval = (xValues.Max() - xValues.Min()) / 10; 

            RS_chart.ChartAreas[0].AxisY.Minimum = yValues.Min(); 
            RS_chart.ChartAreas[0].AxisY.Maximum = yValues.Max();
            RS_chart.ChartAreas[0].AxisY.Interval = (yValues.Max() - yValues.Min()) / 10;

            // Format X and Y axis labels to 3 decimal places
            RS_chart.ChartAreas[0].AxisX.LabelStyle.Format = "F3";
            RS_chart.ChartAreas[0].AxisY.LabelStyle.Format = "F3";

            // Increase font size of the axis titles
            RS_chart.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft San Serif", 12f);
            RS_chart.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft San Serif", 12f);
        }

        private void ExportFSButton_Click(object sender, EventArgs e)
        {

        }

        private void calculateResponseSpectrum_Click(object sender, EventArgs e)
        {
            // Read and validate input fields
            if (string.IsNullOrWhiteSpace(max_period_text.Text) ||
                string.IsNullOrWhiteSpace(period_step_text.Text) ||
                string.IsNullOrWhiteSpace(beta_text.Text) ||
                string.IsNullOrWhiteSpace(gamma_text.Text) ||
                string.IsNullOrWhiteSpace(damping_ratio_text.Text))
            {
                MessageBox.Show("Please enter all the required values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Try to parse the input values
            if (!double.TryParse(max_period_text.Text, out double max_period) ||
                !double.TryParse(period_step_text.Text, out double period_step) ||
                !double.TryParse(beta_text.Text, out double beta) ||
                !double.TryParse(gamma_text.Text, out double gamma) ||
                !double.TryParse(damping_ratio_text.Text, out double damping_ratio))
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values for all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ResponseSpectrumAnalysisClass responseSpectrumAnalysis = new ResponseSpectrumAnalysisClass();

            (Tn, u_max, uv_max, ua_max) = responseSpectrumAnalysis.NewmarksAcceleration(RS_accelArray, max_period, period_step, beta, gamma, damping_ratio);
            string type_label = RS_type_box.Text;
            if (type_label == "Acceleration Response Spectrum")
            {
                plotRS(Tn, ua_max, type_label);
            }
            if (type_label == "Velocity Response Spectrum")
            {
                plotRS(Tn, uv_max, type_label);
            }
            if (type_label == "Displacement Response Spectrum")
            {
                plotRS(Tn, u_max, type_label);
            }
        }
    }
}
