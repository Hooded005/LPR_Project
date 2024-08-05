using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    internal class Revised
    {
        public static (double optimalValue, List<double> decisionVariables) revisedSimplex(LPModel model)
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
                row.Add(numConstraints); // Fill missing coefficients with 0
                row.Add(model.cRHS[i]); // Add the RHS value
                tableau.Add(row);
            }

            // Add the objective function row to the tableau
            List<double> objectiveRow = new List<double>(model.objCoefficients);
            objectiveRow.AddRange(new double[numConstraints]); // Append slack variables
            objectiveRow.Add(0); // Initialize RHS value for the objective function row
            tableau.Add(objectiveRow);

            // Debugging output
            Console.WriteLine("Initial Tableau:");
            PrintTableau(tableau);

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

                // Debugging output
                Console.WriteLine("Tableau after pivoting:");
                PrintTableau(tableau);

                // Update basic and non-basic variables
                basicVariables[leavingVariable] = enteringVariable;
                nonBasicVariables[enteringVariable] = leavingVariable;
            }

            // Debugging output to check dimensions
            Console.WriteLine($"Tableau size: {tableau.Count} rows, {tableau[0].Count} columns");

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

            // Post-processing: Enforce binary constraints
            List<double> binaryDecisionVariables = new List<double>(decisionVariables);
            for (int i = 0; i < model.varTypes.Count - 1; i++)
            {
                if (model.varTypes[i] == "bin")
                {
                    // Enforce binary constraints
                    binaryDecisionVariables[i] = binaryDecisionVariables[i] >= 0.5 ? 1 : 0;
                }
            }

            // Check feasibility of the solution
            if (!CheckFeasibility(binaryDecisionVariables, model))
            {
                Console.WriteLine("Feasible solution not found. Rounding may have introduced infeasibility.");
            }

            return (optimalValue, binaryDecisionVariables);
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

        private static void PrintTableau(List<List<double>> tableau)
        {
            foreach (var row in tableau)
            {
                Console.WriteLine(string.Join("\t", row));
            }
            Console.WriteLine();
        }

        private static bool CheckFeasibility(List<double> decisionVariables, LPModel model)
        {
            for (int i = 0; i < model.cCoefficients.Count; i++)
            {
                double lhs = 0;
                for (int j = 0; j < model.cCoefficients[i].Count; j++)
                {
                    lhs += model.cCoefficients[i][j] * decisionVariables[j];
                }
                if ((model.cSign[i] == "<=" && lhs > model.cRHS[i]) ||
                    (model.cSign[i] == ">=" && lhs < model.cRHS[i]) ||
                    (model.cSign[i] == "=" && lhs != model.cRHS[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
