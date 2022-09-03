using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class fGuessNumber : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int countAnswer;
        private int usersAnswer;

        public fGuessNumber()
        {
            InitializeComponent();
        }

        private void fGuessNumber_Shown(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btnSendAnswer_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tbUserAnswer.Text, out usersAnswer))
            {
                if(usersAnswer == computerNumber)
                {
                    MessageBox.Show("It's right! Congratulations!", "Guess Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MaybePlay();
                }
                else if(usersAnswer > computerNumber)
                {
                    MessageBox.Show("Wrong, the number is too big!", "Guess Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (usersAnswer < computerNumber)
                {
                    MessageBox.Show("Wrong, the number is too small!", "Guess Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                lblCountTry.Text = (--countAnswer).ToString();

                if (countAnswer <= 0)
                {
                    MessageBox.Show($"Ended up trying! Correct answer: {computerNumber}", "Guess Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaybePlay();
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid number", "Guess Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbUserAnswer.Text = "";
        }
        private void MaybePlay()
        {
            if (MessageBox.Show("Would you like to play again?", "Doubler", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NewGame();
            }
            else
                this.Close();
        }

        private void NewGame()
        {
            this.computerNumber = random.Next(1, 100);
            countAnswer = 0;
            lblCountTry.Text = (countAnswer += 10).ToString();

            string massage = "      The game has begun!\n\r" +
                    "--------------------------------------\n\r" +
                    $"      Maximum attempts: {countAnswer}";
            MessageBox.Show(massage, "Guess Number", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void fGuessNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSendAnswer.PerformClick();
        }
    }
}
