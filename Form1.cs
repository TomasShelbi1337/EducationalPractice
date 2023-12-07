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
        double cost;
        double chlCost;
        //
        private void allOperations()
        {
            FlightCh();
            ClassCh();
            ChilCh();
            BagCh();
            CheckingData();
        }
        private void bCalc_Click(object sender, EventArgs e)
        {
            // запуск методов
            allOperations();
        }
        // включение/выключение объекта выбора даты полёта назад
        private void chTb_CheckedChanged(object sender, EventArgs e)
        {
            if (chTb.Checked == false)
            {
                dtBack.Enabled = false;
            }
            else
            {
                dtBack.Enabled = true;
            }
        }
        // включение/выключение объекта поля для ввода количества детей
        private void chChil_CheckedChanged(object sender, EventArgs e)
        {
            if (chChil.Checked == false)
            {
                tQch.Enabled = false;
                tQch.Text = "";
            }
            else
            {
                tQch.Enabled = true;
            }
        }
        // метод в котором определяется уровень класса полёта и высчитывается стоимость
        private void ClassCh()
        {
            if (cbClass.Text == "Comfort")
            {
                cost *= 1.2;
            }
            else if (cbClass.Text == "Business")
            {
                cost *= 1.4;
            }
            else if (cbClass.Text == "First Class")
            {
                cost *= 1.6;
            }
        }
        // метод в котором высчитывается стоимость в зависимости от рейса
        private void FlightCh()
        {
            if (cbFlight.Text == "Ekaterinburg - Moscow")
            {
                cost += 9000;
            }
            else if (cbFlight.Text == "Ekaterinburg - Saint-Petersburg")
            {
                cost += 9300;
            }
            else
            {
                cost += 10700;
            }
        }
        private void CheckingData()
        {
            double allCost = cost + chlCost;
            // проверка того что все данные о покупателе введены
            if (string.IsNullOrWhiteSpace(tName.Text) || string.IsNullOrWhiteSpace(tSurname.Text) || string.IsNullOrWhiteSpace(tPatronymic.Text))
            {
                MessageBox.Show("Введите все данные о покупателе | Enter all the information about the buyer", "Error");
                return;
            }
            // проверка на наличие цифер в полях имя, фамилия, отчество
            else if (!Check(tSurname.Text) || !Check(tName.Text) || !Check(tPatronymic.Text))
            {
                MessageBox.Show("Вводите только буквы в поля Фамилия, Имя и Отчество | Enter only letters in the Last Name, First Name and Patronymic fields", "Error");
                return;
            }
            // проверка того что все данные о рейсе введены
            else if (string.IsNullOrWhiteSpace(cbFlight.Text) || string.IsNullOrWhiteSpace(cbClass.Text) || (chChil.Checked && string.IsNullOrWhiteSpace(tQch.Text)))
            {
                MessageBox.Show("Введите все данные о рейсе | Enter all the information about the flight", "Error");
                return;
            }
            // просьба пользователя убедиться в правильности введённых им данных
            else
            {
                MessageBox.Show($"Стоимость билета на взрослого | Ticket price per adult = {cost}, " +
                    $"Стоимость детских билетов | The cost of children's tickets = {chlCost}, " +
                    $"Общая стоимость | Total cost = {allCost},                                 " 
                    + "         Перейти к оформлению? | Go to registration?", "Check", MessageBoxButtons.YesNo);

                return;
            }
        }
        // метод подсчёта билетов за детей
        private void ChilCh()
        {
            if (chChil.Checked)
            {
                double.TryParse(tQch.Text, out double z);
                chlCost = (cost * 0.9) * z;
            }
            else
            {
                chlCost = 0;
            }
        }
        // проверка флажка багажа
        private void BagCh()
        {
            if (chBag.Checked)
            {
                cost *= 1.02;
            }
        }
        // метод проверки на наличие цифер в полях имя, фамилия, отчество
        private bool Check(string t)
        {
            return t.All(c => char.IsLetter(c));
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
