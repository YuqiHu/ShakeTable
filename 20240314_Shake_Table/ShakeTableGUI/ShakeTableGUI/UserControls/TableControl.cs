using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
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
            //serialPort = new SerialPort("COM3", 500000);
            serialPort = new SerialPort("COM4", 500000);

            try
            {
                serialPort.Open();
            }
            catch
            {
                Console.WriteLine("Unable to open COM3 port - check if it is not in use.");
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // Send command to the Arduino to turn pin 11 on
            if (serialPort.IsOpen)
            {
                //Console.WriteLine("Yes");
                serialPort.Write("1");

                try
                {
                    //serialPort.Write("a");

                    using (StreamReader sr = new StreamReader(ImportFile.Text))
                    {
                        while (!sr.EndOfStream) // Continue reading until the end of the stream
                        {
                            // Read one line
                            string line = sr.ReadLine();
                            // Send the line to Arduino
                            serialPort.WriteLine(line);
                            //Console.WriteLine(line);
                        }

                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(ex.Message);
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
    }
}