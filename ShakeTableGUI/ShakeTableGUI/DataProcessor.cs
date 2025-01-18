using System;
using System.IO;
using System.Collections.Generic;
using ShakeTableGUI.UserControls;
using System.Web.UI;

public class DataProcessor
{
    public static (double[] time, double[] acceleration) ReadTimeAccelerationData(string filePath, string unitOfAcceleration, int skipLines)
    {
        // Read all lines from the file
        string[] lines = File.ReadAllLines(filePath);

        // Lists to store time and acceleration values
        List<double> timeList = new List<double>();
        List<double> accelerationList = new List<double>();

        // Start processing from the second line (skip the header)
        for (int i = skipLines; i < lines.Length; i++)
        {
            // Split the line into columns
            string[] columns = lines[i].Split(new[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (columns.Length == 2)
            {
                // Parse time and acceleration values
                if (double.TryParse(columns[0], out double time) &&
                    double.TryParse(columns[1], out double acceleration))
                {
                    timeList.Add(time);
                    if(unitOfAcceleration == "g")
                        accelerationList.Add(acceleration * 9.80665);
                    else
                        accelerationList.Add(acceleration);
                }
            }
        }

        // Convert lists to arrays and return
        return (timeList.ToArray(), accelerationList.ToArray());
    }
}
