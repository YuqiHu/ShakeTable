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

namespace ShakeTableGUI.UserControls
{
    public partial class Preprocessing : UserControl
    {
        public Preprocessing()
        {
            InitializeComponent();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            // Open the File Dialog to read in a file
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browser Text File",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
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

        private void chart1_Click(object sender, EventArgs e)
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

                Series series = new Series();
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
            foreach (DataGridViewColumn column in ImportDG.Columns)
            {
                // Extract X and Y values from DataGridView and plot into Line Chart
                ta_chart.Series.Clear();

                Series series = new Series();
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

                // X and Y axies title
                ta_chart.ChartAreas[0].AxisX.Title = "Time (s)";
                ta_chart.ChartAreas[0].AxisY.Title = "Acceleration (g)";

                // Increase font size of the axis titles
                ta_chart.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft San Serif", 12f);
                ta_chart.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft San Serif", 12f);
            }

        }


    }
}
