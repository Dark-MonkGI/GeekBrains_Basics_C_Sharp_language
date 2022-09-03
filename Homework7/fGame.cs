using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Homework7
{
    public partial class fGame : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int userNumber;
        private int countSteps;

        public fGame()
        {
            InitializeComponent();
        }

        private void fGame_Shown(object sender, EventArgs e)
        {
            UpdateGameState(userNumber *= 0, random.Next(2, 20));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UpdateGameState(userNumber *= 0, random.Next(2, 20));
        }
        private void btnDoubler_Click(object sender, EventArgs e)
        {
            UpdateGameState(userNumber *= 2);
            lblCountSteps.Text = Convert.ToString(--countSteps);
            CheckWin();
        }
        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            UpdateGameState(++userNumber);
            lblCountSteps.Text = Convert.ToString(--countSteps);
            CheckWin();
        }

        private void UpdateGameState(int userNumber)
        {
            lblCurNum.Text = $"{userNumber}";
        }

        private void UpdateGameState(int userNumber, int computerNumber)
        {
            HowCountSteps(computerNumber);

            string massage = "The game has begun!\n\r" +
                                "----------------------------------\n\r" +
                                $"The given number is: {computerNumber}\n\r" +
                                "----------------------------------\n\r" +
                                $"Maximum number of steps: {countSteps}";

            UpdateGameState(userNumber);
            this.computerNumber = computerNumber;
            lblGenNum.Text = $"{computerNumber}";
            MessageBox.Show(massage, "Doubler", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void HowCountSteps(int computerNumber)
        {
            int count = 1;
            int tempNumber = 1;

            while (tempNumber * 2 <= computerNumber)
            {
                if(tempNumber * 2 == computerNumber)
                {
                    tempNumber *= 2;
                    count++;
                    break;
                }
                tempNumber *=2;
                count++;
            }

            while (tempNumber != computerNumber)
            {
                tempNumber ++;
                count++;
            }
            lblCountSteps.Text = Convert.ToString(count);   
            countSteps = count;
        }

        private void CheckWin()
        {
            if (userNumber == computerNumber)
            {
                MessageBox.Show("You have successfully completed the game!", "Doubler", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                MaybePlay();
            }
            else if (userNumber > computerNumber)
                GameOver();

            if (countSteps <= 0)
                GameOver();
        }

        private void GameOver()
        {
            MessageBox.Show("Game Over!", "Doubler", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            MaybePlay();
        }

        private void MaybePlay()
        {
            if (MessageBox.Show("Would you like to play again?", "Doubler", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                UpdateGameState(userNumber *= 0, random.Next(2, 20));
            else
                this.Close();
        }
    }
}
