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
        // метод для вычисления факториала
        private int Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        // метод вычисления сочетания
        private int CombinationCalculate(int m, int n)
        {
            int result = Factorial(m + n - 1) / (Factorial(n) * Factorial(m - 1));
            return result;
        }
        // метод вычисления размещения
        private int PlacementCalculate(int m, int n)
        {
            int result = (int)Math.Pow(n, m);
            return result;
        }
        // метод вычисления перестановок
        private int PermutationsCalculate(int n)
        {
            int result = Factorial(n);
            return result;
        }
        // кнопка вычислить которая запускает метод
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int.TryParse(txtM.Text, out int m);
            int.TryParse(txtN.Text, out int n);
            // проверка ввода 0 и отрицательных значений
            if (n <= 0 && m <= 0)
            {
                MessageBox.Show("Введённые значения меньше, либо равны 0, введите другие значения");
                ClearFields();
            }
            else
            {
                // запуск метода в зависимости от выбранного пункта
                if (rBtnComb.Checked == true && rBtnPerm.Checked == false && rBtnPlac.Checked == false)
                {
                    // проверка вводимых значений которые больше 20
                    if (n > 20 || m > 20)
                    {
                        MessageBox.Show("Введённые значения больше 20, введите другие значения");
                        ClearFields();
                    }
                    else
                    // вывод результатов метода вычисления сочетания
                    {
                        int res = CombinationCalculate(n, m);
                        lblResult.Text = "Result: " + res.ToString();
                        ClearFields();
                    }

                }
                // вывод результатов метода вычисления перестановок
                if (rBtnComb.Checked == false && rBtnPerm.Checked == true && rBtnPlac.Checked == false)
                {
                    int res = PermutationsCalculate(n);
                    lblResult.Text = "Result: " + res.ToString();
                    ClearFields();
                }
                // вывод результатов метода вычисления размещения
                if (rBtnComb.Checked == false && rBtnPerm.Checked == false && rBtnPlac.Checked == true)
                {
                    int res = PlacementCalculate(n, m);
                    lblResult.Text = "Result: " + res.ToString();
                    ClearFields();
                }
            } 
        }
        // выбор кнопки сочетания
        private void rBtnComb_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnComb.Checked == true)
            {
                rBtnPerm.Checked = false;
                rBtnPlac.Checked = false;
            }
        }
        // выбор кнопки размещения
        private void rBtnPlac_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPlac.Checked == true)
            {
                rBtnPerm.Checked = false;
                rBtnComb.Checked = false;
            }
        }
        // выбор кнопки перестановки
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
        // очистка полей ввода
        private void ClearFields()
        {
            txtM.Text = "";
            txtN.Text = "";
        }
    }
}
