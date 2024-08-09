using System;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new mainForm());






            //to run the CuttingPlane.cs and LPModel.cs files

            LPModel lpModel = new LPModel();
            // Initialize the model with your objective function, constraints, etc.

            CuttingPlane cuttingPlane = new CuttingPlane(lpModel);
            double[] optimalSolution = cuttingPlane.Solve();

            Console.WriteLine("Optimal Integral Solution: " + string.Join(", ", optimalSolution));
        }
    }
}
