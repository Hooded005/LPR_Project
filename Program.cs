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
            LPModel model = readInput.ParseInputFile("C:\\Users\\seanb\\OneDrive\\Documents\\School\\BC - 3RD\\LPR381\\Project\\Project\\Data\\test.txt");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Console.WriteLine("Model found here:");
            Console.WriteLine(model.ConvertToCanonicalForm());      
        }
    }
}
