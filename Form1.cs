using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalPractice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        private int CombinationCalculate(int m, int n)
        {
            int result = Factorial(m + n - 1) / (Factorial(n) * Factorial(m - 1));
            return result;
        }
        private int PlacementCalculate(int m, int n)
        {
            int result = (int)Math.Pow(n, m);
            return result;
        }
        private List<string> FindPermutationsWithRepetitions(string input)
        {
            List<string> permutations = new List<string>();
            GeneratePermutations("", input, permutations);
            return permutations;
        }
        private void GeneratePermutations(string prefix, string input, List<string> permutations)
        {
            int length = input.Length;

            if (length == 0)
            {
                permutations.Add(prefix);
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    GeneratePermutations(prefix + input[i], input, permutations);
                }
            }
        }
        private void PrintPermutations(List<string> permutations)
        {
            foreach (string permutation in permutations)
            {
                lblResult.Text = (permutation + Environment.NewLine);
            }
        }
        private int PermutationsCalculate(int n)
        {
            int result = Factorial(n);
            return result;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int.TryParse(txtM.Text, out int m);
            int.TryParse(txtN.Text, out int n);
            if (rBtnComb.Checked == true && rBtnPerm.Checked == false && rBtnPlac.Checked == false)
            {
                int res = CombinationCalculate(n, m);
                lblResult.Text = "Result: " + res.ToString();
                ClearFields();
            }
            if (rBtnComb.Checked == false && rBtnPerm.Checked == true && rBtnPlac.Checked == false)
            {
                int res = PlacementCalculate(n, m);
                lblResult.Text = "Result: " + res.ToString();
                ClearFields();
            }
            if (rBtnComb.Checked == false && rBtnPerm.Checked == false && rBtnPlac.Checked == true)
            {
                string input = n.ToString();
                List<string> permutations = FindPermutationsWithRepetitions(input);
                PrintPermutations(permutations);
                ClearFields();
            }
        }

        private void rBtnComb_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnComb.Checked == true)
            {
                rBtnPerm.Checked = false;
                rBtnPlac.Checked = false;
            }
        }

        private void rBtnPlac_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPlac.Checked == true)
            {
                rBtnPerm.Checked = false;
                rBtnComb.Checked = false;
            }
        }

        private void rBtnPerm_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPerm.Checked == true)
            {
                rBtnPlac.Checked = false;
                rBtnComb.Checked = false;
                txtM.Enabled = false;
            }
            else
            {
                txtM.Enabled = true;
            }
        }
        private void ClearFields()
        {
            txtM.Text = "";
            txtN.Text = "";
        }
    }
}
