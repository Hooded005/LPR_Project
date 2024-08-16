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
            var shadowPrices = new List<double>();
            int lastRowIndex = solvedModel.cCoefficients.Count - 1;
            int lastColIndex = solvedModel.cCoefficients[lastRowIndex].Count - 1;

            for (int i = 0; i < lastRowIndex; i++)
            {
                double shadowPrice = solvedModel.cCoefficients[i][lastColIndex];
                shadowPrices.Add(shadowPrice);
            }
            return shadowPrices;
        }

        public (string dualityType, double primalObjective, double dualObjective) CalculateDuality(LPModel model)
        {
            // Extract the objective function coefficients (last row)
            List<double> objCoefficients = model.cCoefficients[model.cCoefficients.Count - 1];
            double primalObjective = 0;

            // Calculate the primal objective value
            for (int i = 0; i < model.cCoefficients.Count - 1; i++)
            {
                // Multiply objective function coefficient by the RHS of the corresponding constraint
                primalObjective += objCoefficients[i] * model.cCoefficients[i][model.cCoefficients[i].Count - 1];
            }

            // The dual objective value is typically the RHS value in the objective row
            double dualObjective = objCoefficients[objCoefficients.Count - 1];

            // Determine duality type
            string dualityType = (primalObjective == dualObjective) ? "Strong Duality" : "Weak Duality";

            return (dualityType, primalObjective, dualObjective);
        }
    }
}
