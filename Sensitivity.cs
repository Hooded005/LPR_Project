using System;
using System.Collections.Generic;

namespace Project
{
    internal class Sensitivity
    {
        public (double lowerBound, double upperBound) FindRange(LPModel originalModel, LPModel solvedModel, int rowIndex, int colIndex)
        {
            double lowerBound = double.NegativeInfinity;
            double upperBound = double.PositiveInfinity;
            int lastRow = solvedModel.cCoefficients.Count - 1;
            int lastCol = solvedModel.cCoefficients[lastRow].Count - 1;

            if (rowIndex == lastRow)
            {
                double objCoeff = solvedModel.cCoefficients[lastRow][colIndex];

                for (int j = 0; j < solvedModel.cCoefficients[lastRow].Count - 1; j++) // Exclude the RHS
                {
                    if (j != colIndex)
                    {
                        double tableauCoeff = solvedModel.cCoefficients[lastRow][colIndex];
                        if (tableauCoeff != 0)
                        {
                            // Compute the ratio to determine the impact on the objective function
                            double ratio = tableauCoeff / (solvedModel.cCoefficients[lastRow][lastCol - 1] - objCoeff);
                            Console.WriteLine($"{tableauCoeff} / {solvedModel.cCoefficients[lastRow][j]} - {objCoeff}" +
                                $" = {ratio}\n");

                            if (tableauCoeff < 0)
                            {
                                upperBound = Math.Min(upperBound, ratio);
                            }
                            else if (tableauCoeff > 0)
                            {
                                lowerBound = Math.Max(lowerBound, ratio);
                            }
                        }
                    }
                }
            }
            else
            {
                // Handle constraint sensitivity analysis
                for (int i = 0; i < solvedModel.cCoefficients.Count; i++)
                {
                    if (i != rowIndex)
                    {
                        double constraintCoefficient = solvedModel.cCoefficients[i][colIndex];
                        if (constraintCoefficient != 0)
                        {
                            double ratio = constraintCoefficient / -solvedModel.cCoefficients[i][lastCol - 1];
                            if (constraintCoefficient > 0)
                            {
                                upperBound = Math.Min(upperBound, ratio);
                            }
                            else if (constraintCoefficient < 0)
                            {
                                lowerBound = Math.Max(lowerBound, ratio);
                            }
                        }
                    }
                }
            }

            if (lowerBound > 0)
            {
                upperBound = lowerBound;
                lowerBound = double.NegativeInfinity;
            }
            else if (upperBound < 0)
            {
                lowerBound = upperBound;
                upperBound = double.PositiveInfinity;
            }
            else
            {
                lowerBound = 0;
                upperBound = 0;
            }

            lowerBound = Math.Round(lowerBound, 2);
            upperBound = Math.Round(upperBound, 2);
            return (lowerBound, upperBound);
        }

        public List<double> CalculateShadowPrices(LPModel solvedModel)
        {
            int numConstraints = solvedModel.cCoefficients.Count - 1;
            int numVariables = solvedModel.cCoefficients[0].Count - 1; // Excluding RHS column
            List<double> shadowPrices = new List<double>();

            // The shadow prices are determined from the coefficients of the slack variables in the last row of the tableau
            for (int i = 0; i < numConstraints; i++)
            {
                // The shadow price for each constraint is in the last row, corresponding to the column of the slack variable for that constraint
                double shadowPrice = solvedModel.cCoefficients[numConstraints][i];
                shadowPrices.Add(shadowPrice);
            }

            return shadowPrices;
        }

        public bool CheckDuality(LPModel primalModel, LPModel solvedPrimalModel)
        {
            // Formulate the dual model
            LPModel dualModel = FormulateDual(primalModel);

            // Solve the dual model
            var (optimalDualValue, _, _) = dualModel.Solve();

            // Check if strong duality holds
            double optimalPrimalValue = solvedPrimalModel.Solve().optimalValue;

            // Compare the optimal values of primal and dual
            bool strongDualityHolds = Math.Abs(optimalPrimalValue - optimalDualValue) < 1e-6;

            return strongDualityHolds;
        }

        private LPModel FormulateDual(LPModel primalModel)
        {

            int lastRow = primalModel.cCoefficients.Count - 1;
            int lastCol = primalModel.cCoefficients[lastRow].Count - 1;
            List<List<double>> e = new List<List<double>>();
            LPModel dualModel = new LPModel(e);

            // Set objective function to maximize/minimize based on primal's minimization/maximization
            dualModel.IsMax = !primalModel.IsMax;

            // Number of primal constraints becomes the number of dual variables
            int numVariables = primalModel.cCoefficients[lastRow].Count;
            int numConstraints = primalModel.cCoefficients.Count;

            // Dual objective function coefficients
            dualModel.objCoefficients = new List<double>(numConstraints);
            for (int i = 0; i < numConstraints; i++)
            {
                dualModel.cCoefficients.Add(primalModel.cCoefficients[i]);
            }

            // Dual constraints coefficients
            dualModel.cCoefficients = new List<List<double>>();
            for (int j = 0; j < numVariables; j++)
            {
                var dualRow = new List<double>(numConstraints);
                for (int i = 0; i < numConstraints; i++)
                {
                    dualRow.Add(primalModel.cCoefficients[i][j]);
                }
                dualModel.cCoefficients.Add(dualRow);
            }

            // Dual constraints RHS
            dualModel.cCoefficients[lastRow] = new List<double>(numVariables);
            for (int i = 0; i < numVariables; i++)
            {
                dualModel.cCoefficients.Add(primalModel.cCoefficients[i]);
            }

            // Variable types for the dual model
            dualModel.varTypes = new List<string>();
            for (int i = 0; i < numConstraints; i++)
            {
                dualModel.varTypes.Add("Continuous"); // Assuming continuous variables in the dual model
            }

            return dualModel;
        }
    }
}
