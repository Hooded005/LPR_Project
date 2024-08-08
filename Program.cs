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

            //Application.Run(new mainForm());

            LPModel model = readInput.ParseInputFile("Data/test.txt");
            Console.WriteLine(model.ConvertToCanonicalForm());
            for (int i = 0; i < model.objCoefficients.Count; i++)
            {
                model.objCoefficients[i] *= -1;
                Console.WriteLine(model.objCoefficients[i]);
            }
            var (z, decVar, iterations) = PrimalSimplex.simplex(model);
            string var = "";

            for (int i = 0; i < decVar.Count; i++)
            {
                if (decVar[i] > 0)
                {
                    var += Math.Round(decVar[i], 2) + "x" + i;
                }
            }

            Console.WriteLine($"Z = {z}" +
                $"\nDecision Variables: {string.Join(", ", var)}" +
                $"\n\nTableau:\n{string.Join("\n", iterations)}");
        }
    }
}
