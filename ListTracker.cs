using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class ListTracker
    {

        public double[,] toArray(List<List<double>> table, int rowSize, int colSize)
        {
            double[,] tempArray = new double[rowSize, colSize];
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    tempArray[i, j] = table[i][j];
                }
            }
            return tempArray;
        }

        public List<List<double>> Convert2DArrayToList(double[,] array2D)
        {
            List<List<double>> list2D = new List<List<double>>();

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                List<double> rowList = new List<double>();

                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    rowList.Add(array2D[i, j]);
                }
                list2D.Add(rowList);
            }

            return list2D;
        }
    }
}
