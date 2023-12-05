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
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtXmin.Text, out double Xmin) &&
            double.TryParse(txtXmax.Text, out double Xmax) &&
            double.TryParse(txtStep.Text, out double step))
            {
                // узнаём количество точек графика
                int count = (int)Math.Ceiling((Xmax - Xmin) / step) + 1;
                // массивы точек
                double[] x = new double[count];
                double[] y1 = new double[count];
                double[] y2 = new double[count];
                // переменная для вычислений
                var d = 1.3;
                // цикл для выставления границ под точки
                for (int i = 0; i < count; i++)
                {
                    // формулы вычислений
                    x[i] = Xmin + step * i;
                    y1[i] = Math.Pow(x[i], 4) + Math.Cos(2 + (Math.Pow(x[i], 3)) - d);
                    y2[i] = Math.Cos(Math.Pow(x[i], 2));
                }
                // настраиваем оси графика
                chart1.ChartAreas[0].AxisX.Minimum = Xmin;
                chart1.ChartAreas[0].AxisX.Maximum = Xmax;
                // настраиваем шаг сетки
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
                // задаём точки на графике
                chart1.Series[0].Points.DataBindXY(x, y1);
                chart1.Series[1].Points.DataBindXY(x, y2);
            }
            else
            {
                MessageBox.Show("check the entered data");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
