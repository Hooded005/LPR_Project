﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class mainForm : Form
    {
        string path = "";
        LPModel model = new LPModel();
        OpenFileDialog file = new OpenFileDialog();
        string output = "";

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            tb_display.Text = "";
            tb_display.Text = model.ConvertToCanonicalForm();
        }

        private void btn_knapsack_Click(object sender, EventArgs e)
        {
            lblZans.Text = "";
            lblDVans.Text = "";
            tb_display.Text = "";
            tb_display.Text = model.ConvertToCanonicalForm();
            output = "";

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

                output += $"Branches:\n" +
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
            try
            {
                output = "";

                for (int i = 0; i < model.objCoefficients.Count; i++)
                {
                    model.objCoefficients[i] *= -1;
                }

                var (z, decVar, iterations) = PrimalSimplex.simplex(model, 0);
                string var = "";

                for (int i = 0; i < decVar.Count; i++)
                {
                    if (decVar[i] > 0)
                    {
                        var += Math.Round(decVar[i], 2) + "x" + (i + 1) + "\n";
                    }
                }

                output += $"Z: {Math.Round(z, 2)}\n" +
                  $"Decision Variables: {var}\n" +
                  $"Iterations:\n" +
                  $"{string.Join("\n", iterations)}";

                lblZans.Text = z.ToString();
                lblDVans.Text = var;
                tb_display.Text = output;

                for (int i = 0; i < model.objCoefficients.Count; i++)
                {
                    model.objCoefficients[i] *= -1;
                }
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
    }
}
