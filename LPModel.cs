using System;
using System.Collections.Generic;
using System.Data;
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
            result.Append("Z = ");
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

        // Method to add a new constraint to the LP model
        public void AddConstraint(List<double> newCoefficients, string newSign, double newRHS)
        {
            if (newCoefficients == null || newCoefficients.Count == 0)
            {
                throw new ArgumentException("Invalid constraint: The coefficients cannot be null or empty.");
            }

            if (newSign != "<=" && newSign != ">=" && newSign != "=")
            {
                throw new ArgumentException("Invalid constraint: The sign must be '<=', '>=', or '='.");
            }

            // Add the new constraint to the model
            cCoefficients.Add(newCoefficients);
            cSign.Add(newSign);
            cRHS.Add(newRHS);

            Console.WriteLine("New constraint added to the model.");
        }

        public void removeAddedConstraints(LPModel model)
        {
            int count = model.cCoefficients.Count;

            model.cCoefficients.RemoveAt(count-1);
            model.cSign.RemoveAt(count-1);
            model.cRHS.RemoveAt(count-1);
        }

        // Method to solve the LP problem using the Primal Simplex algorithm
        public (double optimalValue, List<double> decisionVariables, List<string> iterations) Solve()
        {
            // Use the PrimalSimplex class to solve the linear programming model
            var (optimalValue, decisionVariables, iterations) = PrimalSimplex.simplex(this, 0);

            // Return the results from the Simplex algorithm
            return (optimalValue, decisionVariables, iterations);
        }
    }
}