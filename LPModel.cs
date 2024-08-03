using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class LPModel
    {
        public LPModel()
        {
            objCoefficients = new List<double>();
            cCoefficients = new List<List<double>>();
            cSign = new List<string>();
            cRHS = new List<double>();
            varTypes = new List<string>();
        }

        public bool IsMax { get; set; }
        public List<double> objCoefficients { get; set; }
        public List<List<double>> cCoefficients { get; set; }
        public List<string> cSign { get; set; }
        public List<double> cRHS { get; set; }
        public List<string> varTypes { get; set; }

        // Convert model to canonical form
        public string ConvertToCanonicalForm()
        {
            var result = new StringBuilder();

            // Objective function
            result.AppendLine(IsMax ? "Maximize" : "Minimize");
            result.Append("z = ");
            for (int i = 0; i < objCoefficients.Count; i++)
            {
                if (i > 0)
                {
                    result.Append(" + ");
                }
                result.Append($"{objCoefficients[i]}x{i + 1}");
            }
            result.AppendLine();

            // Constraints
            for (int i = 0; i < cCoefficients.Count; i++)
            {
                result.Append($"C{i + 1}: ");
                for (int j = 0; j < cCoefficients[i].Count; j++)
                {
                    if (j > 0)
                    {
                        result.Append(" + ");
                    }
                    result.Append($"{cCoefficients[i][j]}x{j + 1}");
                }
                result.AppendLine($" {cSign[i]} {cRHS[i]}");
            }

            // Variable types
            result.Append("Variable types: ");
            result.AppendLine(string.Join(", ", varTypes));

            return result.ToString();
        }
    }
}
