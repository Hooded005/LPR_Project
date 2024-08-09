using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class PrimalSimplex
    {
        public static (double optimalValue, List<double> decisionVariables, List<string> iterations) simplex(LPModel model, int count)
        {
            int numVariables = model.objCoefficients.Count;
            int numConstraints = model.cCoefficients.Count;

            // Initialize the tableau
            List<List<double>> tableau = new List<List<double>>();
            List<int> basicVariables = new List<int>();
            List<int> nonBasicVariables = Enumerable.Range(0, numVariables).ToList();

            // Initialize basic variables to slack variables
            for (int i = 0; i < numConstraints; i++)
            {
                basicVariables.Add(numVariables + i); // Slack variables are indexed after the original variables
            }

            // Create the tableau
            for (int i = 0; i < numConstraints; i++)
            {
                List<double> row = new List<double>(model.cCoefficients[i]);
                row.AddRange(Enumerable.Repeat(0.0, numConstraints));
                row[numVariables + i] = 1; // Slack variable coefficient
                row.Add(model.cRHS[i]); // Add the RHS value
                tableau.Add(row);
            }


            // Add the objective function row to the tableau
            List<double> objectiveRow = new List<double>(model.objCoefficients);
            objectiveRow.AddRange(Enumerable.Repeat(0.0, numConstraints)); // Append slack variables
            objectiveRow.Add(0); // Initialize RHS value for the objective function row
            tableau.Add(objectiveRow);

            List<string> iterations = new List<string>();

            // Simplex iterations
            while (true)
            {
                // Determine entering variable (most negative coefficient in objective function row)
                int enteringVariable = -1;
                double minValue = 0;
                for (int j = 0; j < numVariables + numConstraints; j++)
                {
                    if (tableau[numConstraints][j] < minValue)
                    {
                        minValue = tableau[numConstraints][j];
                        enteringVariable = j;
                    }
                }

                // Check for optimality
                if (enteringVariable == -1)
                    break;

                // Determine leaving variable using the minimum ratio test
                int leavingVariable = -1;
                double minRatio = double.MaxValue;
                for (int i = 0; i < numConstraints; i++)
                {
                    if (tableau[i][enteringVariable] > 0)
                    {
                        double ratio = tableau[i][numVariables + numConstraints] / tableau[i][enteringVariable];
                        if (ratio < minRatio)
                        {
                            minRatio = ratio;
                            leavingVariable = i;
                        }
                    }
                }

                if (leavingVariable == -1)
                    throw new InvalidOperationException("The problem is unbounded.");

                // Perform pivot operation
                PerformPivotOperation(tableau, enteringVariable, leavingVariable);

                // Save current tableau iteration
                count++;
                iterations.Add(ConvertTableauToString(tableau, count));

                // Update basic and non-basic variables
                basicVariables[leavingVariable] = enteringVariable;
            }

            // Extract optimal value and decision variables
            double optimalValue = tableau[numConstraints][numVariables + numConstraints];
            List<double> decisionVariables = new List<double>(new double[numVariables]);

            for (int i = 0; i < numConstraints; i++)
            {
                if (basicVariables[i] < numVariables)
                {
                    decisionVariables[basicVariables[i]] = tableau[i][numVariables + numConstraints];
                }
            }

            return (optimalValue, decisionVariables, iterations);
        }

        private static void PerformPivotOperation(List<List<double>> tableau, int enteringVariable, int leavingVariable)
        {
            int numRows = tableau.Count;
            int numCols = tableau[0].Count;

            double pivotElement = tableau[leavingVariable][enteringVariable];

            // Normalize the pivot row
            for (int j = 0; j < numCols; j++)
            {
                tableau[leavingVariable][j] /= pivotElement;
            }

            // Update other rows
            for (int i = 0; i < numRows; i++)
            {
                if (i != leavingVariable)
                {
                    double factor = tableau[i][enteringVariable];
                    for (int j = 0; j < numCols; j++)
                    {
                        tableau[i][j] -= factor * tableau[leavingVariable][j];
                    }
                }
            }
        }

        private static string ConvertTableauToString(List<List<double>> tableau, int count)
        {
            var sb = new System.Text.StringBuilder();
            int numCols = tableau[0].Count;
            sb.AppendLine("Tableau " + count);

            foreach (var row in tableau)
            {
                for (int j = 0; j < numCols; j++)
                {
                    // Round each value to 2 decimal places and pad it for alignment
                    sb.Append(row[j].ToString("F2").PadLeft(5));
                    if (j < numCols - 1) sb.Append("\t");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
