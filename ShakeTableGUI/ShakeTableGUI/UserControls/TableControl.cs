using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            serialPort = new SerialPort("COM3", 9600);

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
    }
}
