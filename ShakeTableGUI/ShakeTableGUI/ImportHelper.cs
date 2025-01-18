using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Web.ModelBinding;

namespace ShakeTableGUI
{
    class ImportHelper
    {
        public static string file;

        public static DataTable DataTableFromTextFile(string location, string unit, int delimiterIndex = 0, int skipLines = 0)
        {
            // Read all lines from the file
            string[] allLines = File.ReadAllLines(location);

            // Ensure we skip only if there are enough lines
            if (skipLines >= allLines.Length)
            {
                throw new ArgumentException("Number of lines to skip exceeds the total number of lines in the file.");
            }

            // Skip the specified number of lines
            string[] LineArray = allLines.Skip(skipLines).ToArray();

            char delimiter = '\t'; // Default value
            switch (delimiterIndex)
            {
                case 0:
                    delimiter = '\t';
                    break;
                case 1:
                    delimiter = ',';
                    break;
                case 2:
                    delimiter = ';';
                    break;
                default:
                    throw new ArgumentException("Invalid delimiter index.");
            }

            // Convert the remaining lines to a DataTable
            DataTable result = FromDataTable(LineArray, delimiter);

            result.Columns[0].ColumnName = "Time(s)";
            result.Columns[1].ColumnName = $"Acceleration({unit})";
            return result;
        }

        private static DataTable FromDataTable(string[] LineArray, char delimiter)
        {
            DataTable dt = new DataTable();

            AddColumnToTable(LineArray, delimiter, ref dt);
            AddRowToTable(LineArray, delimiter, ref dt);
            return dt;
        }

        private static void AddRowToTable(string[] valueCollaction, char delimiter, ref DataTable dt)
        {
            // i = 0, read from the first line of the data
            for (int i = 0; i < valueCollaction.Length; i++)
            {
                string[] values = valueCollaction[i].Split(delimiter);
                DataRow dr = dt.NewRow();
                for(int j=0; j<values.Length; j++)
                {
                    dr[j] = values[j];
                }
                dt.Rows.Add(dr);
            }
        }

        private static void AddColumnToTable(string[] columnCollectio, char delimiter, ref DataTable dt)
        {
            string[] columns = columnCollectio[0].Split(delimiter);
            foreach (string columnName in columns) 
            {
                DataColumn dc = new DataColumn(columnName, typeof(string));
                dt.Columns.Add(dc);

            }
        }
    }
}
