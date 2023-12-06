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
        // проверка выбранного варианта 
        private void rCustomer_CheckedChanged(object sender, EventArgs e)
        {
            // вариант заказчик
            if (rCustomer.Checked == true)
            {
                lblPd.Text = "Phone number *";
                tPd.Mask = "+7(000)000-00-00";
                rEmployee.Checked = false;
            }
            // вариант сотрудник
            else
            {
                lblPd.Text = "Date of birth *";
                tPd.Mask = "00.00.0000";
                rCustomer.Checked = false;
            }
        }
        private void btnGen_Click(object sender, EventArgs e)
        {
            // проверка условия, если поля пустые
            if (string.IsNullOrWhiteSpace(tSurname.Text) || string.IsNullOrWhiteSpace(tName.Text) || string.IsNullOrWhiteSpace(tPatronymic.Text) || string.IsNullOrWhiteSpace(tPd.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string login;
            // генерация логина для заказчика
            if (rCustomer.Checked)
            {
                string surname = tSurname.Text;
                string name = tName.Text;
                string patronymic = tPatronymic.Text;
                string s13 = tPd.Text.Substring(12, 1);
                string lastDigits = tPd.Text.Substring(tPd.Text.Length - 2);
                login = $"{surname.Substring(0, 1)}{name.Substring(0, 1)}{patronymic.Substring(0, 1)}{s13}{lastDigits}";
                tLog.Text = login;
            }
            // генерация логина для сотрудника
            else if (rEmployee.Checked)
            {
                string surname = tSurname.Text;
                string name = tName.Text;
                string patronymic = tPatronymic.Text;
                string year = tPd.Text.Substring(7, 3);
                login = $"{surname.Substring(0, 1)}{name.Substring(0, 1)}{patronymic.Substring(0, 1)}{year}";
                tLog.Text = login;
            }
            Random r = new Random();
            // получаем 2 случайных маленьких буквы и 2 заглавных
            char letter1 = (char)('a' + r.Next(0, 26));
            char letter2 = (char)('a' + r.Next(0, 26));
            char letter3 = (char)('A' + r.Next(0, 26));
            char letter4 = (char)('A' + r.Next(0, 26));
            // получаем 2 случайные цифры
            Random rnd = new Random();
            int number1 = rnd.Next(10);
            int number2 = rnd.Next(10);

            // добавляем все символы в переменную
            string password = $"{letter1}{letter2}{letter3}{letter4}{number1}{number2}{letter4}{letter3}";

            // выводим пароль 
            tPas.Text = password;
            if (!Check(tSurname.Text) || !Check(tName.Text) || !Check(tPatronymic.Text))
            {
                MessageBox.Show(" Вводите только буквы в поля Фамилия, Имя и Отчество.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        // метод проверки воодимых значений на наличие цифр
        private bool Check(string text)
        {
            return text.All(c => char.IsLetter(c));
        }
    }
}
