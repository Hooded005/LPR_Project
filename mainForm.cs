using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class mainForm : Form
    {
        string path = "";
        LPModel model = new LPModel();
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
            OpenFileDialog file = new OpenFileDialog();
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
                + "\nZ = " + z + 
                "\nDecision Variables: " + string.Join(", ", decVar);
        }
    }
}
