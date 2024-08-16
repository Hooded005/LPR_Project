using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Excess
    {
        public static List<double> findRHS(List<List<double>> table)
        {
            // Create a new list to store the last column values
            List<double> RHS = new List<double>();

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

        public static int findPivitCol(List<List<double>> table, int pivitRow, int varCount)
        {
            int pivitCol = -1;

            for (int j = 0; j < varCount - 1; j++)
            {
                if (table[pivitRow][j] == 1)
                {
                    pivitCol = j;
                    break;
                }
            }

            return pivitCol;
        }
        public static int findPivitRow(List<List<double>> table, int lastCol, int varAmount)
        {
            int pivitRow = -1;
            for (int i = 1; i < table.Count; i++)
            {
                for (int j = 0; j < varAmount; j++)
                {
                    if ((table[i][lastCol] % 1 != 0) && (table[i][j] == 1))
                    {
                        pivitRow = i;
                        break;
                    }
                }
            }

            return pivitRow;
        }

        public static double findingDec(List<double> rhs)
        {
            for (int i = 1; i < rhs.Count; i++)
            {
                if (rhs[i] % 1 != 0)
                {
                    return rhs[i];
                }
            }
            return -1;
        }
        public static int findingLimitUpper(double decimalVal)
        {
            double upper;

            upper = Math.Ceiling(decimalVal);

            return (Convert.ToInt32(upper));
        }
        public static List<List<double>> addingExcessConstraint(List<List<double>> table, List<double> rhs, int pivitCol, double dec, int lastCol)
        {
            int upper = findingLimitUpper(dec);
            rhs.Add(upper);

            List<double> newRow = new List<double>();

            foreach (var row in table)
            {
                if (row.Count > 0)
                {
                    row.RemoveAt(lastCol);
                }
            }

            for (int i = 0; i < lastCol; i++)
            {
                if (i == (pivitCol))
                {
                    newRow.Add(1);
                }
                else if (i == (lastCol - 1))
                {
                    newRow.Add(-1);
                }
                else if (i == lastCol)
                {
                    newRow.Add(upper);
                }
                else
                {
                    newRow.Add(0);
                }
            }

            table.Add(newRow);


            for (int i = 0; i < table.Count; i++)
            {
                if (i == table.Count - 1)
                {
                    table[i].Insert(table[i].Count - 2, 0);
                }
                else
                {
                    table[i].Add(0);
                }
            }

            for (int i = 0; i < table.Count; i++)
            {
                if (i < rhs.Count)
                {
                    table[i].Add(rhs[i]);
                }
            }

            int lastRow = table.Count - 1;
            lastCol = table[0].Count - 1;

            for (int i = 0; i < table[lastRow].Count; i++)
            {
                if (table[lastRow][i] != 0)
                {
                    table[lastRow][i] = table[lastRow][i] * -1;
                }
            }
            return table;
        }
        public static List<List<double>> simplifyConstraintExcess(List<List<double>> table, int pivitCol, int lastRow, int lastCol)
        {
            int potentialPivit = -1;

            for (int i = 0; i < table.Count; i++)
            {
                if (table[i][pivitCol] == 1)
                {
                    potentialPivit = i;
                    break;
                }
            }

            if ((table[potentialPivit][pivitCol] - table[lastRow][pivitCol]) == 0)
            {
                for (int i = 0; i < table[potentialPivit].Count; i++)
                {
                    table[lastRow][i] = table[potentialPivit][i] - table[lastRow][i];
                }
            }
            else
            {
                for (int i = 0; i < table[potentialPivit].Count; i++)
                {
                    table[lastRow][i] = table[potentialPivit][i] + table[lastRow][i];      //jou vout is hier hy + nie alles nie erens gooi het goed net na n 0 toe
                }
            }

            if (table[lastRow][lastCol] > 0)
            {
                for (int i = 0; i < table[lastRow].Count; i++)
                {
                    if (table[lastRow][i] != 0)
                    {
                        table[lastRow][i] = table[lastRow][i] * -1;
                    }
                }
            }
            return table;
        }

        public static int ratioCheck(List<List<double>> table, int lastRow)
        {
            int pivitCol = -1;
            double lowestRatio = 999999;
            double value = 0;

            for (int i = 0; i < table[lastRow].Count - 1; i++)
            {
                if (table[lastRow][i] < 0)
                {
                    value = Math.Abs(table[0][i] / table[lastRow][i]);
                    if (value <= lowestRatio)
                    {
                        pivitCol = i;
                    }
                }
            }

            return pivitCol;
        }

        public static bool optimalityCheck(List<double> rhs)
        {
            for (int i = 1; i < rhs.Count; i++)
            {
                if (rhs[i] % 1 != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
