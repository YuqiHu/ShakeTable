using System;
using System.Linq;

namespace ResponseSpectrumAnalysis
{
    public class ResponseSpectrumAnalysisClass
    {
        public (double[], double[], double[], double[]) NewmarksAcceleration(double[] at, double max_period, double dt, double beta, double gamma, double xi)
        {
            // Assume values for mass
            double m = 100000.0;
            const double pi = Math.PI;

            // initialize the Tn array
            int arrayLength = (int)(max_period / dt);
            double[] Tn = new double[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Tn[i] = (i + 1) * dt;
            }

            // Calculate the stiffness
            var k = Tn.Select(Tni => 4 * Math.Pow(pi, 2) / Math.Pow(Tni, 2) * m).ToArray();

            // Calculate damping coefficient
            double[] c = k.Select(stiff => 2 * xi * Math.Sqrt(m * stiff)).ToArray();

            // Calculate the ground excitation
            double[] pt = at.Select(accl => accl * m * -1).ToArray();

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
                    da[i] = 1 / (beta * Math.Pow(dt, 2)) * du[i] - (1 / (beta * dt)) * uv[i] - 1 / (2 * beta) * ua[i];

                    // Update u, uv, ua
                    u[i + 1] = u[i] + du[i];
                    uv[i + 1] = uv[i] + dv[i];
                    ua[i + 1] = ua[i] + da[i];
                }

                // Find the maximum absolute values
                u_max[j] = u.Select(Math.Abs).Max();
                uv_max[j] = uv.Select(Math.Abs).Max();
                ua_max[j] = ua.Select(Math.Abs).Max() / 9.81;
            }

            return (Tn, u_max, uv_max, ua_max);
        }
    }

    
}
