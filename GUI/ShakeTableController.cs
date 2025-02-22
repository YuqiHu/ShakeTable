using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GUI
{
    public partial class ShakeTableController : Form
    {
        SerialPort serialPort;

        public ShakeTableController()
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShakeTableController_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(serialPort.BytesToRead > 0)
            {
                byte[] data = new byte[serialPort.BytesToRead];
                serialPort.Read(data, 0, data.Length);
                var str = System.Text.Encoding.Default.GetString(data);
                Console.WriteLine(str);
            }
        }
    }
}
