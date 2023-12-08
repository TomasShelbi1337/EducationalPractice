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
        private Button[] buttons;
        private bool player1Turn;
        private int turnCount;
        public Form1()
        {
            InitializeComponent();
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            NewGame();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                if (player1Turn)
                    button.Text = "X";
                else
                    button.Text = "O";

                turnCount++;
                player1Turn = !player1Turn;

                if (CheckForWin())
                {
                    string winner = player1Turn ? "Player 2" : "Player 1";
                    MessageBox.Show(winner + " wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewGame();
                }
                else if (turnCount == 9)
                {
                    MessageBox.Show("It's a tie!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewGame();
                }
            }
        }

        private bool CheckForWin()
        {
            // Проверяем все возможные комбинации выигрышных троек
            if (CheckLine(0, 1, 2) || CheckLine(3, 4, 5) || CheckLine(6, 7, 8) ||
                CheckLine(0, 3, 6) || CheckLine(1, 4, 7) || CheckLine(2, 5, 8) ||
                CheckLine(0, 4, 8) || CheckLine(2, 4, 6))
            {
                return true;
            }

            return false;
        }

        private bool CheckLine(int index1, int index2, int index3)
        {
            if (buttons[index1].Text != "" &&
                buttons[index1].Text == buttons[index2].Text &&
                buttons[index1].Text == buttons[index3].Text)
            {
                return true;
            }

            return false;
        }

        private void NewGame()
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
            }

            player1Turn = true;
            turnCount = 0;
        }
    }
}
