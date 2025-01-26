using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ShakeTableGUI.UserControls
{
    public partial class TableControl : UserControl
    {

        SerialPort serialPort;
        double[] time;
        double[] displacement;
        private bool stopRequested = false;
        const double m_to_cm = 100.0;
        const double factor_of_precision = 100000.0;
        public TableControl()
        {
            InitializeComponent();
            InitializeSerialPorts();
            //plot_time_accel_monitor();
            //plot_time_disp_monitor();

        }

        private void InitializeSerialPorts()
        {
            // Get a list of serial port names
            string[] ports = SerialPort.GetPortNames();

            // Make this list to show in the comboBox_comPort
            comboBox_comPort.Items.AddRange(ports);
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            // Get the selected com_port from the comboBox
            string com_port = comboBox_comPort.Text;

            if (string.IsNullOrEmpty(com_port))
            {
                MessageBox.Show("Please choose a COM port.", "Missing COM Port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Set the serial port
            int baudRate = 500000;
            serialPort = new SerialPort(com_port, baudRate);

            try
            {
                // Try to open the serial port
                serialPort.Open();
            }
            catch(Exception ex)
            {
                // Popup message box to show the error message
                MessageBox.Show($"Unable to open {com_port} port - {ex.Message}", "Cannot Connect to Arduino Board", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stopRequested = false;

            
            // Send the instruction to Arduino board
            if (serialPort.IsOpen)
            {
                await Task.Run(() =>
                {
                    try
                    {
                        if (!double.TryParse(timesteps.Text, out double timeStep))
                        {
                            MessageBox.Show("Invalid input. Please enter valid numeric values for all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Send the time step once
                        serialPort.DiscardInBuffer();
                        serialPort.DiscardOutBuffer();
                        serialPort.WriteLine(timeStep.ToString("F6"));
                        Console.WriteLine($"Sent Time Step: {timeStep}");

                        // Wait for acknowledgment from Arduino
                        string time_response = serialPort.ReadLine().Trim();
                        if (time_response != "Timestep OK")
                        {
                            Console.WriteLine($"Unexpected response: {time_response}");
                            return;
                        }

                        Console.WriteLine("Timestep acknowledged by Arduino.");

                        // Send displacement values
                        foreach (double value in displacement)
                        {
                            if (stopRequested)
                            {
                                Console.WriteLine("Data transfer stopped by user.");
                                break;
                            }

                            double valueIncm = value * m_to_cm;
                            valueIncm = valueIncm * factor_of_precision;
                            string data = valueIncm.ToString("F6");
                            serialPort.WriteLine(data);
                            Console.WriteLine($"Sent Displacement: {data}");

                            // Wait for acknowledgment from Arduino
                            string response = serialPort.ReadLine().Trim();
                            if (response != "OK")
                            {
                                Console.WriteLine($"Unexpected response: {response}");
                                break;
                            }
                            //Console.WriteLine($"response: {response}");
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        Console.WriteLine("Data transfer was cancelled.");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("Error while communicating with the Arduino:");
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        // Ensure the serial port is always closed
                        serialPort.Close();
                    }
                });
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            stopRequested = true;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            // Choosing the file to open
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

            // Show the input file path to the dialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImportFile.Text = openFileDialog1.FileName;
                int skip_header_lines = 1;

                (time, displacement) = DataProcessor.ReadTimeDisplacementData(ImportFile.Text, skip_header_lines);
            }
        }


        private void Arduino_Table_Control_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received: ");
            Console.Write(indata);
        }

        private void ReadFile()
        {
            string filePath = ImportFile.Text;

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // Write each line in the file to Arduino
                    serialPort.WriteLine(line + "#");
                    Console.WriteLine("Send" + line);

                    //// Receive the feedback from Arduino
                    //string receivedData = serialPort.ReadLine();
                    //Console.WriteLine("Feedback from Arduino: " + receivedData);

                    //if (receivedData.Contains("wait"))
                    //{
                    //    Console.WriteLine("Waiting for Arduino...");
                    //    WaitForResponse("continue");
                    //}

                }
            }
        }

        private void WaitForResponse(string expectedResponse)
        {
            string receivedData;
            do
            {
                receivedData = serialPort.ReadLine();
                Console.WriteLine("Received: " + receivedData);
            } while (!receivedData.Contains(expectedResponse));
        }

        private void plot_time_accel_monitor()
        {
            // Initialize the chart
            Time_Accel_Monitor.Series.Clear();
            Time_Accel_Monitor.Series.Add(new Series("Theoretical"));
            Time_Accel_Monitor.Series["Theoretical"].ChartType = SeriesChartType.Line;
            Time_Accel_Monitor.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            Time_Accel_Monitor.ChartAreas["ChartArea1"].AxisX.Interval = 5.00;

            Preprocessing preProcessing = new Preprocessing();

            if(preProcessing.time != null && preProcessing.acceleration != null) 
            {
                Time_Accel_Monitor.Series["Theoretical"].Points.AddXY(preProcessing.time, preProcessing.acceleration);
            }

            // X and Y axies title
            Time_Accel_Monitor.ChartAreas[0].AxisX.Title = "Time (s)";
            Time_Accel_Monitor.ChartAreas[0].AxisY.Title = "Acceleration (g)";

            // Increase font size of the axis titles
            Time_Accel_Monitor.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft San Serif", 12f);
            Time_Accel_Monitor.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft San Serif", 12f);

        }

        private void plot_time_disp_monitor()
        {
            // Initialize the chart
            Time_Disp_Monitor.Series.Clear();
            Time_Disp_Monitor.Series.Add(new Series("Theoretical"));
            Time_Disp_Monitor.Series["Theoretical"].ChartType = SeriesChartType.Line;
            Time_Disp_Monitor.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            Time_Disp_Monitor.ChartAreas["ChartArea1"].AxisX.Interval = 5.00;


            // Extract data from DataGridView and plot into Line Chart
            using (StreamReader sr = new StreamReader("../../../../GroundMotions/2022_GM2.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Split the line by delimiter
                    string[] parts = line.Split('\t');

                    // Assuming the first column is X and the second column is Y
                    if (parts.Length >= 2 && double.TryParse(parts[0], out double x) && double.TryParse(parts[1], out double y))
                    {
                        Time_Disp_Monitor.Series["Theoretical"].Points.AddXY(x, y);
                    }
                }
            }

            // X and Y axies title
            Time_Disp_Monitor.ChartAreas[0].AxisX.Title = "Time (s)";
            Time_Disp_Monitor.ChartAreas[0].AxisY.Title = "Displacement (mm)";

            // Increase font size of the axis titles
            Time_Disp_Monitor.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft San Serif", 12f);
            Time_Disp_Monitor.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft San Serif", 11f);

        }
    }
}