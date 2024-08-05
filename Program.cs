using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LPModel model = readInput.ParseInputFile("Data/test.txt");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Console.WriteLine("Model found here:");
            Console.WriteLine(model.ConvertToCanonicalForm());

            List<double> obj = new List<double>();
            List<double> con = new List<double>();
            double RHS = model.cRHS[0];

            // Objective function coefficients
            obj = new List<double>(model.objCoefficients);

            // Extract the first constraint's coefficients and RHS as the knapsack capacity
            con = model.cCoefficients[0];

            var (z, decVar) = Knapsack.BranchAndBoundKnapsack(obj, con, RHS);

            Console.WriteLine("Z = " + z);            
            Console.WriteLine("Decision Variables: " + string.Join(", ", decVar));
        }
    }
}
