using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Knapsack
    {
        // Solve the 0/1 Knapsack problem using dynamic programming
        public static (string nodes, double maxValue, List<int> bestItems) BranchAndBoundKnapsack(List<double> values, List<double> weights, double capacity)
        {
            int n = values.Count;
            double maxProfit = 0;
            List<int> bestItems = new List<int>();
            string nodes = "";

            PriorityQueue<knapsackNode> pq = new PriorityQueue<knapsackNode>((a, b) => b.Bound.CompareTo(a.Bound));

            knapsackNode u = new knapsackNode();
            knapsackNode v = new knapsackNode();

            u.Level = -1;
            u.Profit = 0;
            u.Weight = 0;
            u.Bound = CalculateBound(u, n, values, weights, capacity);
            pq.Enqueue(u);

            while (pq.Count > 0)
            {
                u = pq.Dequeue();
                if (u.Level == n - 1) continue;

                v.Level = u.Level + 1;

                // Including the next item
                v.Weight = u.Weight + weights[v.Level];
                v.Profit = u.Profit + values[v.Level];
                v.IncludedItems = new List<int>(u.IncludedItems) { v.Level };

                if (v.Weight <= capacity && v.Profit > maxProfit)
                {
                    maxProfit = v.Profit;
                    bestItems = new List<int>(v.IncludedItems );
                }

                v.Bound = CalculateBound(v, n, values, weights, capacity);
                if (v.Bound > maxProfit) pq.Enqueue(new knapsackNode
                {
                    Level = v.Level,
                    Profit = v.Profit,
                    Weight = v.Weight,
                    Bound = v.Bound,
                    IncludedItems = new List<int>(v.IncludedItems)
                });

                // Excluding the next item
                v.Weight = u.Weight;
                v.Profit = u.Profit;
                v.IncludedItems = new List<int>(u.IncludedItems);

                v.Bound = CalculateBound(v, n, values, weights, capacity);
                if (v.Bound > maxProfit) pq.Enqueue(new knapsackNode
                {
                    Level = v.Level,
                    Profit = v.Profit,
                    Weight = v.Weight,
                    Bound = v.Bound,
                    IncludedItems = new List<int>(v.IncludedItems)
                });

                for (int i = 0; i < v.IncludedItems.Count; i++)
                {
                    v.IncludedItems[i] += 1;
                }
                nodes = DisplayNode(u, v);
            }

            for (int i = 0; i < bestItems.Count; i++)
            {
                bestItems[i] += 1;
            }

            return (nodes, maxProfit, bestItems);
        }

        private static double CalculateBound(knapsackNode u, int n, List<double> values, List<double> weights, double capacity)
        {
            if (u.Weight >= capacity) return 0;
            double profitBound = u.Profit;
            double j = u.Level + 1;
            double totalWeight = u.Weight;

            while (j < n && totalWeight + weights[(int)j] <= capacity)
            {
                totalWeight += weights[(int)j];
                profitBound += values[(int)j];
                j++;
            }

            if (j < n) profitBound += (capacity - totalWeight) * values[(int)j] / weights[(int)j];
            return profitBound;
        }

        private static string DisplayNode(knapsackNode u, knapsackNode v)
        {
            return $"Current Branch - Level: {u.Level}, Profit: {u.Profit}, Weight: {u.Weight}, Bound: {u.Bound}" +
                $"\nNext Branch - Level: {v.Level}, Profit: {v.Profit}, Weight: {v.Weight}, Bound: {v.Bound}, Included Items: {string.Join(", ", v.IncludedItems)}";
        }
    }

    internal class PriorityQueue<T>
    {
        private List<T> data;
        private Comparison<T> comparer;

        public PriorityQueue(Comparison<T> comparison)
        {
            this.data = new List<T>();
            this.comparer = comparison;
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int ci = data.Count - 1;

            while (ci > 0)
            {
                int pi = (ci - 1) / 2;
                if (comparer(data[ci], data[pi]) <= 0) break;
                T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
                ci = pi;
            }
        }

        public T Dequeue()
        {
            int li = data.Count - 1;
            T frontItem = data[0];
            data[0] = data[li];
            data.RemoveAt(li);
            --li;

            int pi = 0;
            while (true)
            {
                int ci = pi * 2 + 1;
                if (ci > li) break;
                int rc = ci + 1;
                if (rc <= li && comparer(data[rc], data[ci]) > 0) ci = rc;
                if (comparer(data[pi], data[ci]) >= 0) break;
                T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp;
                pi = ci;
            }
            return frontItem;
        }

        public int Count
        {
            get { return data.Count; }
        }
    }
}
