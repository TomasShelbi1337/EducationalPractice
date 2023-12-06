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
                // переменная для вычислений
                var y = 5;
                var z = 5;
                var c = 5;
                // цикл для выставления границ под точки
                for (int i = 0; i < count; i++)
                {
                    // формулы вычислений
                    x[i] = Xmin + step * i;
                    y1[i] = (Math.Log(Math.Pow(y, - Math.Sqrt(Math.Abs(z)))) * (z - y / 2) + Math.Pow(Math.Sin(c), 2) * Math.Atan(c));
                }
                // настраиваем оси графика
                chart1.ChartAreas[0].AxisX.Minimum = Xmin;
                chart1.ChartAreas[0].AxisX.Maximum = Xmax;
                // настраиваем шаг сетки
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
                // задаём точки на графике
                chart1.Series[0].Points.DataBindXY(x, y1);
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
