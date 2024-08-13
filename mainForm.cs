using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class mainForm : Form
    {
        string path = "";
        LPModel model = readInput.ParseInputFile("Data/test.txt");
        OpenFileDialog file = new OpenFileDialog();
        string output = "";
        List<List<double>> tableau;
        string tempPath = "temp.txt";

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cutting plane button

            lblZans.Text = "";
            lblDVans.Text = "";
            tb_display.Text = "";
            output = model.ConvertToCanonicalForm();

            try
            {
                convertToOptimal(model);
                // Initialize the CuttingPlane class with the current LP model
                CuttingPlane cuttingPlane = new CuttingPlane(model);

                // Solve the LP problem using the Cutting Plane method
                var (solution, iterations) = cuttingPlane.Solve();

                // Display the results
                string var = "";
                double z = 0;
                convertToOptimal(model);

                for (int i = 0; i < solution.Length; i++)
                {
                    if (solution[i] > 0)
                    {
                        z += model.objCoefficients[i] * solution[i];
                        var += $"{solution[i]}x{i + 1}\n";
                    }
                }

                output += $"\nZ: {z}\n" +
                  $"Decision Variables: {var}\n" +
                  $"Iterations:\n" +
                  $"{string.Join("\n", iterations)}";

                lblZans.Text = z.ToString();
                lblDVans.Text = var;
                tb_display.Text = output;

                model.removeAddedConstraints(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            file.Title = "Select a file to upload";
            file.Filter = "Text Files|*.txt";

            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                model = readInput.ParseInputFile(path);
            }
            for (int i = 0; i < model.cCoefficients.Count; i++)
            {
                if (model.cCoefficients[i].Count < model.objCoefficients.Count)
                {
                    int dif = model.objCoefficients.Count - model.cCoefficients[i].Count;
                    for (int j = 0; j < dif; j++)
                    {
                        model.cCoefficients[i].Add(0);
                    }
                }
            }

            for (int i = 0; i < model.cCoefficients.Count; i++)
            {
                if (model.cCoefficients[i].Count > model.objCoefficients.Count)
                {
                    int dif = model.cCoefficients[i].Count - model.objCoefficients.Count;
                    int index = model.cCoefficients[i].Count - 1;

                    for (int j = 0; j < dif; j++)
                    {
                        model.cCoefficients[i].RemoveAt(index);
                        index--;
                    }
                }
            }
        }

        private void btn_canonical_Click(object sender, EventArgs e)
        {
            tb_display.Text = model.ConvertToCanonicalForm();
        }

        private void btn_knapsack_Click(object sender, EventArgs e)
        {
            lblZans.Text = "";
            lblDVans.Text = "";
            tb_display.Text = model.ConvertToCanonicalForm();
            output = model.ConvertToCanonicalForm();

            if (model.cCoefficients.Count == 1)
            {
                List<double> obj = new List<double>();
                List<double> con = new List<double>();
                double RHS = model.cRHS[0];

                obj = new List<double>(model.objCoefficients);

                con = model.cCoefficients[0];

                var (z, decVar) = Knapsack.BranchAndBoundKnapsack(obj, con, RHS, tb_display);

                lblZans.Text = z.ToString();
                lblDVans.Text = string.Join(", ", decVar);

                output += $"\nBranches:\n" +
                    $"{tb_display.Text}";
            }
            else
            {
                MessageBox.Show($"Knapsack algorithm can only contain 1 constraint" +
                    $"\nThe model has: {model.cCoefficients.Count} constraints", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    File.WriteAllText(path, tb_display.Text);
                    model = readInput.ParseInputFile(path);
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No file selected to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            file.Title = "Select a file to save to";
            file.Filter = "Text Files|*.txt";

            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                File.WriteAllText(path, output);
            }
        }

        private void btn_revised_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Simplex_Click(object sender, EventArgs e)
        {
            lblZans.Text = "";
            lblDVans.Text = "";
            tb_display.Text = "";
            output = model.ConvertToCanonicalForm();

            try
            {
                convertToOptimal(model);

                var (z, decVar, iterations) = PrimalSimplex.simplex(model, 0);
                string var = "";

                for (int i = 0; i < decVar.Count; i++)
                {
                    if (decVar[i] > 0)
                    {
                        var += Math.Round(decVar[i], 2) + "x" + (i + 1) + "\n";
                    }
                }

                output += $"\nZ: {Math.Round(z, 2)}\n" +
                  $"Decision Variables: {var}\n" +
                  $"Iterations:\n" +
                  $"{string.Join("\n", iterations)}";

                lblZans.Text = z.ToString();
                lblDVans.Text = var;
                tb_display.Text = output;

                convertToOptimal(model);
                string finalIter = iterations[iterations.Count - 1];

                tableau = ConvertTableauStringToList(finalIter);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            file.Title = "Select a file to upload";
            file.Filter = "Text Files|*.txt";

            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
            }
            tb_display.Text = File.ReadAllText(path);
        }
        private static LPModel convertToOptimal(LPModel model)
        {
            for (int i = 0; i < model.objCoefficients.Count; i++)
            {
                model.objCoefficients[i] *= -1;
            }
            return model;
        }
        private static List<List<double>> ConvertTableauStringToList(string tableauText)
        {
            var lines = tableauText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<List<double>>();

            // Skip the first line (title or header)
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Replace commas with dots
                line = line.Replace(',', '.');

                var elements = line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                var row = new List<double>();

                foreach (var element in elements)
                {
                    if (double.TryParse(element, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                    {
                        row.Add(value);
                    }
                    else
                    {
                        throw new FormatException($"Invalid number format: {element}");
                    }
                }
                result.Add(row);
            }

            return result;
        }

        private void btn_Activity_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {
                string solution = "";
                string heading = "";
                string toFile = "";

                for (int i = 0; i < tableau.Count; i++)
                {
                    for (int j = 0; j < tableau[i].Count; j++)
                    {
                        solution += tableau[i][j] + "\t";
                        if (i == 0)
                        {
                            if (j == tableau[i].Count - 1)
                            {

                                heading += "RHS";
                            }
                            else
                            {
                                heading += $"x{j + 1}\t";
                            }
                        }
                    }
                    solution += "\n";
                }

                toFile += heading + "\n" + solution;
                File.WriteAllText(tempPath, toFile);
                tb_display.Text = File.ReadAllText(tempPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
