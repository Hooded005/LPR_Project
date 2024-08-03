using System.Collections.Generic;

namespace Project
{
    internal class knapsackNode
    {
        public knapsackNode()
        {
            IncludedItems = new List<int>();
        }

        public int Level { get; set; }
        public double Profit { get; set; }
        public double Weight { get; set; }
        public double Bound { get; set; }
        public List<int> IncludedItems { get; set; }
    }
}
