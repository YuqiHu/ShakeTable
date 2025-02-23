using System;
using System.Linq;
using System.Windows.Forms;

public class TimeDisplacementConverter
{
    public static (double[] time, double[] displacement) ConvertToDisplacement(double[] time, double[] acceleration, double displacementLimit)
    {
        if (time.Length != acceleration.Length)
            throw new ArgumentException("Time and acceleration arrays must have the same length.");

        int n = time.Length;
        double[] velocity = new double[n];
        double[] displacement = new double[n];

        // Step 1: Integrate acceleration to calculate velocity using the trapezoidal rule
        for (int i = 1; i < n; i++)
        {
            double dt = time[i] - time[i - 1];
            velocity[i] = velocity[i - 1] + 0.5 * dt * (acceleration[i] + acceleration[i - 1]);
        }

        // Step 2: Detrend velocity to eliminate drift
        double avgVelocity = velocity.Average();
        for (int i = 0; i < n; i++)
        {
            velocity[i] -= avgVelocity;
        }

        // Step 3: Integrate velocity to calculate displacement
        for (int i = 1; i < n; i++)
        {
            double dt = time[i] - time[i - 1];
            displacement[i] = displacement[i - 1] + 0.5 * dt * (velocity[i] + velocity[i - 1]);
        }


        // Step 4: Show the warning if maximum displcaement after integration is larger than the shake table maximum displacement limit
        // and recompute the time-displacement data.
        double maxDisp = displacement.Max();
        double minDisp = displacement.Min();
        double maxAbsDisp = Math.Max(Math.Abs(maxDisp), Math.Abs(minDisp));

        if (maxAbsDisp > displacementLimit)
        {
            // Show warning message
            MessageBox.Show(
                "The maximum displacement from direct integration exceeds the maximum displacement of the shake table. " +
                "Time-displacement data has been rescaled to match the time-acceleration data.",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            // Compute scaling factor α to reduce displacement while keeping acceleration constant
            double scalingFactor = displacementLimit / maxAbsDisp;

            // Rescale displacement
            for (int i = 0; i < n; i++)
            {
                displacement[i] *= scalingFactor;
            }

            // Rescale time
            double timeScalingFactor = Math.Sqrt(scalingFactor);
            for (int i = 0; i < n; i++)
            {
                time[i] *= timeScalingFactor;
            }

            // Rescale velocity
            double velocityScalingFactor = Math.Sqrt(scalingFactor);
            for (int i = 0; i < n; i++)
            {
                velocity[i] *= velocityScalingFactor;
            }

            // Step 5: Resample time-displacement data to fixed 0.01-second time steps
            // Why 0.01-second time step? Because I cannot make it work with other time steps. :)
            double[] resampledTime = ResampleTime(time, 0.01);
            double[] resampledDisplacement = Interpolate(time, displacement, resampledTime);

            return (resampledTime, resampledDisplacement);
        }

        return (time, displacement);
    }

    // Helper function to resample time array to fixed time steps
    private static double[] ResampleTime(double[] originalTime, double fixedTimeStep)
    {
        double startTime = originalTime[0];
        double endTime = originalTime[originalTime.Length - 1];
        int numSteps = (int)Math.Ceiling((endTime - startTime) / fixedTimeStep);
        double[] resampledTime = new double[numSteps];

        for (int i = 0; i < numSteps; i++)
        {
            resampledTime[i] = startTime + i * fixedTimeStep;
        }

        return resampledTime;
    }

    // Helper function to interpolate displacement values at resampled time points
    private static double[] Interpolate(double[] originalTime, double[] originalDisplacement, double[] resampledTime)
    {
        double[] resampledDisplacement = new double[resampledTime.Length];
        int originalIndex = 0;

        for (int i = 0; i < resampledTime.Length; i++)
        {
            double targetTime = resampledTime[i];

            // Find the interval in the original time array where the target time lies
            while (originalIndex < originalTime.Length - 1 && originalTime[originalIndex + 1] < targetTime)
            {
                originalIndex++;
            }

            // Perform linear interpolation
            if (originalIndex < originalTime.Length - 1)
            {
                double t0 = originalTime[originalIndex];
                double t1 = originalTime[originalIndex + 1];
                double x0 = originalDisplacement[originalIndex];
                double x1 = originalDisplacement[originalIndex + 1];

                resampledDisplacement[i] = x0 + (x1 - x0) * (targetTime - t0) / (t1 - t0);
            }
            else
            {
                // If target time is beyond the last original time point, use the last displacement value
                resampledDisplacement[i] = originalDisplacement[originalTime.Length - 1];
            }
        }

        return resampledDisplacement;
    }

}