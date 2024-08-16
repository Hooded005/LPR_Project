using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class TwoPhase
    {
        List<double> RHS = new List<double>();
        Checks Checks = new Checks();
        public List<double> findRHS(List<List<double>> table)
        {
            // Create a new list to store the last column values
            RHS.Clear();
            // Populate the RHS list with the last column of each row
            foreach (var row in table)
            {
                if (row.Count > 0)
                {
                    RHS.Add(row[row.Count - 1]);
                }
            }
            return RHS;
        }

        public int findPivitRow(List<double> rhs, List<List<double>> table)
        {
            bool foundNeg = false;
            int pivotRow = -1;
            for (int i = 1; i < rhs.Count; i++)
            {
                foundNeg = false;
                if (rhs[i] < 0)
                {
                    for (int j = 0; j < table[i].Count - 1; j++)
                    {
                        if (table[i][j] < 0)
                        {
                            foundNeg = true;
                            break;
                        }
                    }
                }
                if (foundNeg)
                {
                    pivotRow = i;
                }
            }

            return pivotRow;
        }

        public int findPivitCol(List<List<double>> table, int pivitRow)
        {
            double lowestRatio = 999999;
            double value = 0;
            int pivitCol = -1;

            for (int i = 0; i < table[pivitRow].Count - 1; i++)
            {
                if (table[pivitRow][i] < 0)
                {
                    value = Math.Abs(table[0][i] / table[pivitRow][i]);
                    if (value < lowestRatio)
                    {
                        lowestRatio = value;
                        pivitCol = i;
                    }
                }
            }
            return pivitCol;
        }

        double NormalizeToZero(double value)
        {
            return Math.Abs(value) < 1e-10 ? 0.0 : value;
        }

        public List<List<double>> twoPhaseMath(List<List<double>> Pre, int pivitRow, int pivitCol)
        {
            List<List<double>> newTable = new List<List<double>>();
            List<double> newRow = new List<double>();

            for (int i = 0; i < Pre[pivitRow].Count; i++)
            {
                double value = Pre[pivitRow][i] / Pre[pivitRow][pivitCol];
                newRow.Add(NormalizeToZero(value));  // Normalize the value to avoid -0
            }

            for (int i = 0; i < Pre.Count; i++)  // Don't subtract 1 here; iterate over all rows
            {
                if (i == pivitRow)
                {
                    continue;  // Skip the pivot row
                }

                List<double> row = new List<double>();

                for (int j = 0; j < Pre[i].Count; j++)
                {
                    double value = Pre[i][j] - (Pre[i][pivitCol] * newRow[j]);
                    row.Add(NormalizeToZero(value));  // Normalize the value to avoid -0
                }

                newTable.Add(row);
            }

            newTable.Insert(pivitRow, newRow);

            return newTable;
        }

        public bool optimalityCheck(List<double> rhs)
        {
            for (int i = 1; i < rhs.Count; i++)
            {
                if (rhs[i] < 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
