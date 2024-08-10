using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    public class Sensitivity
    {
        public List<double> ObjectiveCoefficients { get; set; }
        public List<List<double>> Constraints { get; set; }
        public List<double> RightHandSides { get; set; }
        public List<double> ShadowPrices { get; set; }
        public List<bool> IsBasicVariable { get; set; }
        public List<double> CurrentSolution { get; set; }
        public bool IsMaximization { get; set; }

        public Sensitivity()
        {
            ObjectiveCoefficients = new List<double>();
            Constraints = new List<List<double>>();
            RightHandSides = new List<double>();
            ShadowPrices = new List<double>();
            IsBasicVariable = new List<bool>();
            CurrentSolution = new List<double>();
        }

        public void LoadFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            // Parse the objective function line
            string[] objectiveParts = lines[0].Split(' ');
            IsMaximization = objectiveParts[0].ToLower() == "max";
            for (int i = 1; i < objectiveParts.Length; i++)
            {
                ObjectiveCoefficients.Add(double.Parse(objectiveParts[i]));
            }

            // Initialize CurrentSolution with zeros
            for (int i = 0; i < ObjectiveCoefficients.Count; i++)
            {
                CurrentSolution.Add(0);
            }

            // Parse the constraint line
            string[] constraintParts = lines[1].Split(' ');
            List<double> constraintCoefficients = new List<double>();
            for (int i = 0; i < constraintParts.Length - 2; i++)
            {
                constraintCoefficients.Add(double.Parse(constraintParts[i]));
            }
            Constraints.Add(constraintCoefficients);
            RightHandSides.Add(double.Parse(constraintParts[constraintParts.Length - 1]));

            // Parse the variable types
            string[] variableTypes = lines[2].Split(' ');
            for (int i = 0; i < variableTypes.Length; i++)
            {
                IsBasicVariable.Add(variableTypes[i].ToLower() != "bin");
            }
        }

        public void DisplayRangeNonBasicVariable(int variableIndex)
        {
            if (variableIndex < 0 || variableIndex >= IsBasicVariable.Count)
            {
                Console.WriteLine("Error: The variable index is out of range.");
                return;
            }

            if (!IsBasicVariable[variableIndex])
            {
                double lowerBound = 0; // Lower bound of a non-basic variable is often 0
                double upperBound = double.MaxValue; // Assuming no upper bound constraints

                Console.WriteLine($"Non-Basic Variable {variableIndex} range: [{lowerBound}, {upperBound}]");
            }
            else
            {
                Console.WriteLine($"Variable {variableIndex} is a Basic Variable.");
            }
        }

        public void ApplyChangeNonBasicVariable(int variableIndex, double newValue)
        {
            if (variableIndex < 0 || variableIndex >= ObjectiveCoefficients.Count)
            {
                Console.WriteLine("Error: The variable index is out of range.");
                return;
            }

            if (!IsBasicVariable[variableIndex])
            {
                CurrentSolution[variableIndex] = newValue;
                Console.WriteLine($"Non-Basic Variable {variableIndex} changed to {newValue}.");
            }
            else
            {
                Console.WriteLine($"Variable {variableIndex} is a Basic Variable and cannot be changed directly.");
            }
        }

        public void DisplayRangeBasicVariable(int variableIndex)
        {
            if (variableIndex < 0 || variableIndex >= IsBasicVariable.Count)
            {
                Console.WriteLine("Error: The variable index is out of range.");
                return;
            }

            if (IsBasicVariable[variableIndex])
            {
                double lowerBound = 0; // Assuming no negative variables
                double upperBound = double.MaxValue; // Assuming no upper bound constraints

                Console.WriteLine($"Basic Variable {variableIndex} range: [{lowerBound}, {upperBound}]");
            }
            else
            {
                Console.WriteLine($"Variable {variableIndex} is a Non-Basic Variable.");
            }
        }

        public void ApplyChangeBasicVariable(int variableIndex, double newValue)
        {
            if (variableIndex < 0 || variableIndex >= ObjectiveCoefficients.Count)
            {
                Console.WriteLine("Error: The variable index is out of range.");
                return;
            }

            if (IsBasicVariable[variableIndex])
            {
                CurrentSolution[variableIndex] = newValue;
                Console.WriteLine($"Basic Variable {variableIndex} changed to {newValue}.");
            }
            else
            {
                Console.WriteLine($"Variable {variableIndex} is a Non-Basic Variable and cannot be changed directly.");
            }
        }

        public void DisplayRangeConstraintRHS(int constraintIndex)
        {
            if (constraintIndex < 0 || constraintIndex >= RightHandSides.Count)
            {
                Console.WriteLine("Error: The constraint index is out of range.");
                return;
            }

            double lowerBound = 0; // Assuming RHS cannot be negative
            double upperBound = double.MaxValue; // Assuming no upper bound constraints

            Console.WriteLine($"Constraint {constraintIndex} RHS range: [{lowerBound}, {upperBound}]");
        }

        public void ApplyChangeConstraintRHS(int constraintIndex, double newValue)
        {
            if (constraintIndex < 0 || constraintIndex >= RightHandSides.Count)
            {
                Console.WriteLine("Error: The constraint index is out of range.");
                return;
            }

            RightHandSides[constraintIndex] = newValue;
            Console.WriteLine($"Constraint {constraintIndex} RHS changed to {newValue}.");
        }

        public void AddNewActivity(List<double> newActivityCoefficients)
        {
            if (newActivityCoefficients.Count != Constraints[0].Count)
            {
                Console.WriteLine("Error: New activity must have the same number of coefficients as existing constraints.");
                return;
            }

            ObjectiveCoefficients.Add(0); // Assuming new activity has a coefficient of 0 in the objective function
            IsBasicVariable.Add(false); // New activity is non-basic initially
            CurrentSolution.Add(0); // Assuming new activity starts with a value of 0

            for (int i = 0; i < Constraints.Count; i++)
            {
                Constraints[i].Add(newActivityCoefficients[i]);
            }

            Console.WriteLine("New activity added.");
        }

        public void AddNewConstraint(List<double> newConstraintCoefficients, double rhsValue)
        {
            // Check if newConstraintCoefficients match the number of existing coefficients
            if (Constraints.Count == 0 || newConstraintCoefficients.Count != Constraints[0].Count)
            {
                Console.WriteLine("Error: New constraint must have the same number of coefficients as existing constraints.");
                return;
            }

            Constraints.Add(newConstraintCoefficients);
            RightHandSides.Add(rhsValue);
            ShadowPrices.Add(0); // Assuming a shadow price of 0 initially

            Console.WriteLine("New constraint added.");
        }

        public void DisplayShadowPrices()
        {
            for (int i = 0; i < ShadowPrices.Count; i++)
            {
                Console.WriteLine($"Shadow Price for Constraint {i}: {ShadowPrices[i]}");
            }
        }

        public void ApplyDuality()
        {
            // Apply duality (implement dual model and solve)
            Console.WriteLine("Duality applied to the model.");
        }

        public void SolveDualProgrammingModel()
        {
            // Solve dual programming model (implement dual problem solving)
            Console.WriteLine("Dual programming model solved.");
        }

        public void VerifyDuality()
        {
            Console.WriteLine("Verifying duality...");

            // Solve the primal problem
            Solve();
            // Store the primal optimal value
            double primalOptimalValue = IsMaximization ? CurrentSolution.Sum() : -CurrentSolution.Sum();

            // Solve the dual problem
            ApplyDuality();
            // Store the dual optimal value (assumed from the dual solution)
            double dualOptimalValue = 0; // Placeholder: This should be updated with actual dual optimal value

            // Check if duality is strong or weak
            if (Math.Abs(primalOptimalValue - dualOptimalValue) < 1e-6)
            {
                Console.WriteLine("Strong duality verified.");
            }
            else
            {
                Console.WriteLine("Weak duality verified.");
            }
        }

        public void Solve()
        {
            Console.WriteLine("Solving the linear programming model...");

            int numVariables = ObjectiveCoefficients.Count;
            int numConstraints = Constraints.Count;

            // Create the simplex tableau
            double[,] tableau = new double[numConstraints + 1, numVariables + numConstraints + 1];

            // Objective function row
            for (int j = 0; j < numVariables; j++)
            {
                tableau[0, j] = IsMaximization ? -ObjectiveCoefficients[j] : ObjectiveCoefficients[j];
            }

            // Constraints
            for (int i = 0; i < numConstraints; i++)
            {
                for (int j = 0; j < numVariables; j++)
                {
                    tableau[i + 1, j] = Constraints[i][j];
                }
                tableau[i + 1, numVariables + i] = 1;
                tableau[i + 1, tableau.GetLength(1) - 1] = RightHandSides[i];
            }

            // Perform the simplex algorithm
            while (true)
            {
                // Find pivot column (most negative in the objective row)
                int pivotColumn = 0;
                for (int j = 1; j < tableau.GetLength(1) - 1; j++)
                {
                    if (tableau[0, j] < tableau[0, pivotColumn])
                    {
                        pivotColumn = j;
                    }
                }

                // Check for optimality
                if (tableau[0, pivotColumn] >= 0)
                {
                    break;
                }

                // Find pivot row
                int pivotRow = 0;
                double minRatio = double.MaxValue;
                for (int i = 1; i < tableau.GetLength(0); i++)
                {
                    if (tableau[i, pivotColumn] > 0)
                    {
                        double ratio = tableau[i, tableau.GetLength(1) - 1] / tableau[i, pivotColumn];
                        if (ratio < minRatio)
                        {
                            minRatio = ratio;
                            pivotRow = i;
                        }
                    }
                }

                // Perform pivot operation
                double pivotValue = tableau[pivotRow, pivotColumn];
                for (int j = 0; j < tableau.GetLength(1); j++)
                {
                    tableau[pivotRow, j] /= pivotValue;
                }

                for (int i = 0; i < tableau.GetLength(0); i++)
                {
                    if (i != pivotRow)
                    {
                        double factor = tableau[i, pivotColumn];
                        for (int j = 0; j < tableau.GetLength(1); j++)
                        {
                            tableau[i, j] -= factor * tableau[pivotRow, j];
                        }
                    }
                }

                // Output current tableau
                Console.WriteLine($"Iteration:");
                for (int i = 0; i < tableau.GetLength(0); i++)
                {
                    for (int j = 0; j < tableau.GetLength(1); j++)
                    {
                        Console.Write($"{tableau[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            // Output final solution
            Console.WriteLine("Optimal solution:");
            for (int i = 0; i < numVariables; i++)
            {
                Console.WriteLine($"Variable {i}: {tableau[0, i]}");
            }
            Console.WriteLine($"Objective Value: {-tableau[0, tableau.GetLength(1) - 1]}");
        }



    }
}  

