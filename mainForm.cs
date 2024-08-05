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
                MessageBox.Show(path);
            }
        }

        private void btn_canonical_Click(object sender, EventArgs e)
        {
            model = readInput.ParseInputFile(path);
            tb_display.Text = model.ConvertToCanonicalForm();
        }

        private void btn_knapsack_Click(object sender, EventArgs e)
        {
            List<double> obj = new List<double>();
            List<double> con = new List<double>();
            double RHS = model.cRHS[0];

            // Objective function coefficients
            obj = new List<double>(model.objCoefficients);

            // Extract the first constraint's coefficients and RHS as the knapsack capacity
            con = model.cCoefficients[0];

            var (z, decVar) = Knapsack.BranchAndBoundKnapsack(obj, con, RHS);

            tb_display.Text = model.ConvertToCanonicalForm()
                + "\n" + Knapsack.BranchAndBoundKnapsack(obj, con, RHS)
                + "\nZ = " + z +
                "\nDecision Variables: " + string.Join(", ", decVar);
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
            // Check if a file path is available
            if (!string.IsNullOrEmpty(path))
            {
                // Save the content of the RichTextBox back to the file
                try
                {
                    File.WriteAllText(path, tb_display.Text);
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
    }
}
