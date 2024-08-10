using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    internal class readInput
    {
        public static LPModel ParseInputFile(string filePath)
        {
            string testPath = "C:\\Users\\carst\\OneDrive\\Documents\\Belgium 2024\\LPRProject\\LPR_Project\\Data\\test.txt";

            LPModel model = new LPModel();
            string[] lines = File.ReadAllLines(testPath);

            string[] objParts = lines[0].Split(' ');
            model.IsMax = objParts[0].ToLower() == "max";

            for (int i = 1; i < objParts.Length; i++)
            {
                model.objCoefficients.Add(double.Parse(objParts[i]));
            }

            for (int i = 1; i < lines.Length - 1; i++)
            {
                string[] cParts = lines[i].Split(' ');

                int signIndex = 0;

                for (int j = 0; j < cParts.Length; j++)
                {
                    if (cParts[j] == "<=" || cParts[j] == ">=" || cParts[j] == "=")
                    {
                        signIndex = j;
                        break;
                    }
                }

                List<double> cCoefficients = new List<double>();

                for (int j = 0; j < signIndex; j++)
                {
                    cCoefficients.Add(double.Parse(cParts[j]));
                }
                model.cCoefficients.Add(cCoefficients);

                model.cSign.Add(cParts[signIndex]);
                model.cRHS.Add(double.Parse(cParts[signIndex + 1]));
            }

            string[] varTypes = lines[lines.Length - 1].Split(' ');
            foreach (string type in varTypes)
            {
                model.varTypes.Add(type);
            }
            return model;
        }
    }
}