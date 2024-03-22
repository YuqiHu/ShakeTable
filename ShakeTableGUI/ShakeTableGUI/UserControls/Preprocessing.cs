using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

// Used for FFT
using MathNet.Numerics.IntegralTransforms;
// Used for Complex Numbers
using System.Numerics;
using MathNet.Numerics;

namespace ShakeTableGUI.UserControls
{
    public partial class Preprocessing : UserControl
    {
        public Preprocessing()
        {
            InitializeComponent();

            // Initialize the chart
            ta_chart.Series.Clear();

            // Set gridlines to be visible
            ta_chart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            ta_chart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
        }

        private void ImportButton_Click(object sender, EventArgs e)
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
                ImportFile.Text = openFileDialog1.FileName;
                ImportHelper.file = ImportFile.Text;

                ImportDG.DataSource = ImportHelper.DataTableFromTextFile(ImportFile.Text);
            }

            PlotTimeAccelerationData();

        }

        private void ImportFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImportDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PlotTimeAccelerationData()
        {
            // Initialize the chart
            ta_chart.Series.Clear();

            // Extract data from DataGridView and plot into Line Chart
            foreach (DataGridViewColumn column in ImportDG.Columns)
            {
                // Extract X and Y values from DataGridView and plot into Line Chart
                ta_chart.Series.Clear();

                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 2;

                foreach (DataGridViewRow row in ImportDG.Rows)
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

                ta_chart.Series.Add(series);
            }
            // X and Y axies title
            ta_chart.ChartAreas[0].AxisX.Title = "Time (s)";
            ta_chart.ChartAreas[0].AxisY.Title = "Acceleration (g)";

            // Increase font size of the axis titles
            ta_chart.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft San Serif", 12f);
            ta_chart.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft San Serif", 12f);

        }

        
        private void plot_time_disp()
        {
            // Initialize the chart
            Time_Disp_chart.Series.Clear();


            // Extract data from DataGridView and plot into Line Chart
            foreach (DataGridViewColumn column in td_DG.Columns)
            {
                // Extract X and Y values from DataGridView and plot into Line Chart
                Time_Disp_chart.Series.Clear();

                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 2;

                foreach (DataGridViewRow row in td_DG.Rows)
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

                Time_Disp_chart.Series.Add(series);

                // X and Y axies title
                Time_Disp_chart.ChartAreas[0].AxisX.Title = "Time (s)";
                Time_Disp_chart.ChartAreas[0].AxisY.Title = "Displacement (mm)";

                // Increase font size of the axis titles
                Time_Disp_chart.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft San Serif", 12f);
                Time_Disp_chart.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft San Serif", 12f);
            }

        }

        private void Convert_ta_ts_Click(object sender, EventArgs e)
        {
            double timeStep = 0.001;
            double[] acclData = ImportDG.Rows
                                    .OfType<DataGridViewRow>()
                                    .Where(row => !row.IsNewRow)
                                    .Select(row => Convert.ToDouble(row.Cells[1].Value))
                                    .ToArray();
            Complex32[] dispData = Acc2Disp(acclData, timeStep);


            td_DG.Columns.Add("Time", "Time");
            td_DG.Columns.Add("Real", "Real Part");
            // Populate the datagrid
            for (int i = 0; i < dispData.Length; i++)
            {
                double time = i * timeStep;
                td_DG.Rows.Add(time, dispData[i].Real);
            }
            plot_time_disp();
        }

        static Complex32[] Acc2Disp(double[] accTimeData, double dt)
        {
            int N1 = accTimeData.Length;
            int N = (int)Math.Pow(2, Math.Ceiling(Math.Log(N1) / Math.Log(2))); // Next power of 2
            if (N > N1)
            {
                Array.Resize(ref accTimeData, N); // Pad array with 0's
            }

            double df = 1 / (N * dt); // Frequency increment
            double Nyq = 1 / (2 * dt); // Nyquist frequency

            Complex32[] accFreqData = new Complex32[N];
            for (int i = 0; i < N; i++)
            {
                accFreqData[i] = new Complex32((float)accTimeData[i], 0);
            }

            Fourier.Forward(accFreqData);

            for (int i = 0; i < N; i++)
            {
                double f = -Nyq + i * df; // Organize frequency vector
                if (f != 0)
                {
                    accFreqData[i] /= new Complex32((float)(2 * Math.PI * f), 0).Power(2);
                }
                else
                {
                    accFreqData[i] = Complex32.Zero;
                }
            }

            Fourier.Inverse(accFreqData);

            Complex32[] dispTimeData = new Complex32[N1];
            Array.Copy(accFreqData, dispTimeData, N1);

            return dispTimeData;
        }

    }
}
