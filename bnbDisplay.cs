using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class bnbDisplay : Form
    {

        BnB bnB = new BnB();
        public bnbDisplay()
        {
            InitializeComponent();
        }

        public void tb_bnb_TextChanged(object sender, EventArgs e)
        {

        }
        static void PrintTable(Dictionary<int, double[,]> optimalTables, RichTextBox richTextBox)
        {
            // Clear any existing text in the RichTextBox
            richTextBox.Clear();

            foreach (var kvp in optimalTables)
            {
                // Append the key to the RichTextBox
                richTextBox.AppendText($"Key: {kvp.Key}\n");

                double[,] array2D = kvp.Value;

                // Iterate through the 2D array
                for (int i = 0; i < array2D.GetLength(0); i++)
                {
                    for (int j = 0; j < array2D.GetLength(1); j++)
                    {
                        // Append each element to the RichTextBox with formatting
                        richTextBox.AppendText(array2D[i, j].ToString("0.##").PadRight(1) + "\t");
                    }
                    // Newline after each row
                    richTextBox.AppendText("\n");
                }
                // Extra line between different arrays
                richTextBox.AppendText("\n");
            }
        }

        private void bnbDisplay_Load(object sender, EventArgs e)
        {
            Dictionary<int, double[,]> values = bnB.FindOptmal();
            PrintTable(values, tb_bnb);
        }
    }
}
