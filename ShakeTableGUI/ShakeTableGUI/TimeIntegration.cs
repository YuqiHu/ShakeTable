using System;
using System.Linq;

public class TimeDisplacementConverter
{
    public static double[] ConvertToDisplacement(double[] time, double[] acceleration, double displacementLimit)
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

        if (displacement.Max() > displacementLimit || displacement.Min() < -displacementLimit)
            throw new ArgumentException("The maximum displacement exceed the capacity of the shake table.");

        return displacement;
    }
}