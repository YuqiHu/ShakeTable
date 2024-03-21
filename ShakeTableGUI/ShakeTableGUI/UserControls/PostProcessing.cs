using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // Create a mass array to vary the time steps
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
        private void plotRS()
        {
            // Initialize the chart



        }

        private void RS_type_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
