using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ShakeTableGUI.UserControls
{
    public partial class Preprocessing : UserControl
    {
        public double[] time;
        public double[] acceleration;
        public double[] displacement;

        public Preprocessing()
        {
            InitializeComponent();
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
                importFileTextBox.Text = openFileDialog1.FileName;
                ImportHelper.file = importFileTextBox.Text;

                // Read and validate input fields
                if (string.IsNullOrWhiteSpace(unitOfAcceleration.Text)||
                    string.IsNullOrWhiteSpace(skipHeaderLinesText.Text))
                {
                    MessageBox.Show("Please choose the unit of acceleration.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(skipHeaderLines.Text, out int skip_header_lines))
                {
                    MessageBox.Show("Invalid input. Please specify the number of header lines to skip.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Read the file data
                (time, acceleration) = DataProcessor.ReadTimeAccelerationData(importFileTextBox.Text, unitOfAcceleration.Text, skip_header_lines);

                timeAccelerationDataGrid.DataSource = ImportHelper.DataTableFromTextFile(importFileTextBox.Text, unitOfAcceleration.Text, delimiterOptions.SelectedIndex, skip_header_lines);

                PlotTimeAccelerationData();
            }
        }


        private void PlotTimeAccelerationData()
        {
            // Initialize the chart
            timeAccelerationChart.Series.Clear();
            timeAccelerationChart.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            timeAccelerationChart.ChartAreas["ChartArea1"].AxisX.Interval = 5.00;

            // Extract data from DataGridView and plot into Line Chart
            foreach (DataGridViewColumn column in timeAccelerationDataGrid.Columns)
            {
                // Extract X and Y values from DataGridView and plot into Line Chart
                timeAccelerationChart.Series.Clear();

                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 2;

                foreach (DataGridViewRow row in timeAccelerationDataGrid.Rows)
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

                timeAccelerationChart.Series.Add(series);
            }
            // X and Y axies title
            timeAccelerationChart.ChartAreas[0].AxisX.Title = "Time (s)";
            timeAccelerationChart.ChartAreas[0].AxisY.Title = "Acceleration (g)";

            // Increase font size of the axis titles
            timeAccelerationChart.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft San Serif", 12f);
            timeAccelerationChart.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft San Serif", 12f);
        }

        private void Convert_ta_ts_Click(object sender, EventArgs e)
        {
            // The maximum displacement of the shake table is 0.06 m per side
            double displacementLimit = 0.06;

            displacement = TimeDisplacementConverter.ConvertToDisplacement(time, acceleration, displacementLimit);

            PlotTimeDisplacementData();
            ShowTimeDisplacementDataOnDataGrid();
        }

        private void PlotTimeDisplacementData()
        {
            if (time == null || displacement == null || time.Length != displacement.Length)
            {
                throw new ArgumentException("Time and displacement arrays must be non-null and have the same length.");
            }

            // Initialize the chart
            timeDisplacementChart.Series.Clear();
            timeDisplacementChart.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            timeDisplacementChart.ChartAreas["ChartArea1"].AxisX.Interval = 5.00;

            // Create a new series for the plot
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                BorderWidth = 2
            };

            // Add data points to the series
            for (int i = 0; i < time.Length; i++)
            {
                series.Points.AddXY(time[i], displacement[i]);
            }

            // Add the series to the chart
            timeDisplacementChart.Series.Add(series);

            // Configure axis titles and font sizes
            timeDisplacementChart.ChartAreas["ChartArea1"].AxisX.Title = "Time (s)";
            timeDisplacementChart.ChartAreas["ChartArea1"].AxisY.Title = "Displacement (m)";

            // Increase font size of the axis titles
            timeDisplacementChart.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Microsoft Sans Serif", 12f);
            timeDisplacementChart.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Microsoft Sans Serif", 11f);
        }

        private void ShowTimeDisplacementDataOnDataGrid()
        {
            if (time == null || displacement == null || time.Length != displacement.Length)
            {
                throw new ArgumentException("Time and displacement arrays must be non-null and have the same length.");
            }

            // Clear existing rows and columns
            timeDisplacementDataGrid.Columns.Clear();
            timeDisplacementDataGrid.Rows.Clear();

            // Add columns for Time and Displacement
            timeDisplacementDataGrid.Columns.Add("Time", "Time (s)");
            timeDisplacementDataGrid.Columns.Add("Displacement", "Displacement (m)");

            // Use a List to store rows temporarily
            var rows = new List<object[]>();
            for (int i = 0; i < time.Length; i++)
            {
                rows.Add(new object[] { time[i].ToString("F3"), displacement[i].ToString("F8") });
            }

            // Add all rows at once
            foreach (var row in rows)
            {
                timeDisplacementDataGrid.Rows.Add(row);
            }

            timeDisplacementDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            timeDisplacementDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            timeDisplacementDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }


        private void ExportFSButton_Click(object sender, EventArgs e)
        {
            // Create save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Export Data";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name
                string fileName = saveFileDialog.FileName;

                // Write data to the file
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    // Write column headers
                    sw.WriteLine("Time(s)\tDisplacement(m)");

                    if (time.Length != displacement.Length)
                        throw new Exception("Time data series and displacement data series have different length.");

                    // Write data rows
                    for (int i = 0; i < time.Length; i++)
                    {
                        sw.WriteLine($"{time[i]}\t{displacement[i]}");
                    }
                }

                MessageBox.Show("Data exported successfully!", "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
