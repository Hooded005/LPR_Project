using System;

namespace Project
{
    internal class Sensitivity
    {
        public (double lowerBound, double upperBound) FindRange(LPModel originalModel, LPModel solvedModel, int rowIndex, int colIndex)
        {
            double lowerBound = double.NegativeInfinity;
            double upperBound = double.PositiveInfinity;
            int row = solvedModel.cCoefficients.Count - 1;
            int col = solvedModel.cCoefficients[row].Count - 1;

            // Get the coefficients of the target variable from the solved model's tableau
            double targetCoefficient = solvedModel.cCoefficients[rowIndex][colIndex];

            // Check if the target variable is a basic variable
            bool isBasicVariable = targetCoefficient != 0;

            if (isBasicVariable)
            {
                // For a basic variable, we analyze the constraint (RHS values)
                for (int i = 0; i < solvedModel.cCoefficients.Count; i++)
                {
                    if (i != rowIndex)
                    {
                        double constraintCoefficient = -solvedModel.cCoefficients[i][colIndex];
                        if (constraintCoefficient != 0)
                        {
                            double ratio = solvedModel.cCoefficients[row][col] / constraintCoefficient;
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
            else
            {
                // For non-basic variables (those with zero value in the solution),
                // we check how much their coefficient in the objective function can change.
                for (int j = 0; j < solvedModel.cCoefficients.Count; j++)
                {
                    if (j != colIndex)
                    {
                        double objectiveCoefficient = solvedModel.cCoefficients[j][colIndex];
                        if (objectiveCoefficient != 0)
                        {
                            double ratio = -solvedModel.cCoefficients[row][col] / objectiveCoefficient;
                            if (objectiveCoefficient > 0)
                            {
                                upperBound = Math.Min(upperBound, ratio);
                            }
                            else if (objectiveCoefficient < 0)
                            {
                                lowerBound = Math.Max(lowerBound, ratio);
                            }
                        }
                    }
                }
            }
            upperBound = Math.Round(upperBound, 2);
            lowerBound = Math.Round(lowerBound, 2);
            return (lowerBound, upperBound);
        }
    }
}
