using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShakeTableGUI.UserControls
{
    public partial class TableControl : UserControl
    {

        SerialPort serialPort;

        public TableControl()
        {
            InitializeComponent();
            InitializeSerialPorts();

        }

        private void InitializeSerialPorts()
        {
            // Get a list of serial port names
            string[] ports = SerialPort.GetPortNames();

            // Make this list to show in the comboBox_comPort
            comboBox_comPort.Items.AddRange(ports);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // Get the selected com_port from the comboBox
            string com_port = comboBox_comPort.Text;

            if (string.IsNullOrEmpty(com_port))
            {
                MessageBox.Show("Please choose a COM port.", "Missing COM Port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Set the serial port
            serialPort = new SerialPort(com_port, 500000);

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

            // Send the instruction to Arduino board
            if (serialPort.IsOpen)
            {
                try
                {
                    ReadFile();
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error reading file:");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // Ensure the serial port is always closed
                    serialPort.Close(); 
                }
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            // Send command to the Arduino to turn pin 11 off
            if (serialPort.IsOpen)
            {
                //Console.WriteLine("No");
                serialPort.Write("0");
            }
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

                    // Receive the feedback from Arduino
                    string receivedData = serialPort.ReadLine();
                    Console.WriteLine("Feedback from Arduino: " + receivedData);

                    if (receivedData.Contains("wait"))
                    {
                        Console.WriteLine("Waiting for Arduino...");
                        WaitForResponse("continue");
                    }

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

    }
}