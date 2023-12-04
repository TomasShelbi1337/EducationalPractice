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
        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public static int CombinationCalculate(int m, int n)
        {

            int result = Factorial(n + m - 1) / (Factorial(m) * Factorial(n - 1));
            return result;
        }
        private int PlacementCalculate(int m, int n)
        {
            int result = (int) Math.Pow(n, m);
            return result;
        }
        private int PermutationsCalculate(int n)
        {
            int result = Factorial(n);
            return result;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtM.Text);
            int n = int.Parse(txtN.Text);
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
                int res = PermutationsCalculate(n);
                lblResult.Text = "Result: " + res.ToString();
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
