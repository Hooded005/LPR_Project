using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Checks
    {
        public Checks() { }

        public List<List<double>> negZero(List<List<double>> table)
        {
            for (int i = 0; i < table.Count; i++)
            {
                for (int j = 0; j < table[0].Count; j++)
                {
                    if ((table[i][j] == 0) || (table[i][j] == -0))
                    {
                        table[i][j] = 0;
                    }
                }
            }
            return table;
        }
    }
}
