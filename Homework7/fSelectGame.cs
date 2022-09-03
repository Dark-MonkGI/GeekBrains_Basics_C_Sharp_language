using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class fSelectGame : Form
    {
        fGame fGame = new fGame();
        fGuessNumber fGuessNumber = new fGuessNumber(); 
        public fSelectGame()
        {
            InitializeComponent();
        }

        private void btnDoubler_Click(object sender, EventArgs e)
        {
            this.Hide();
            fGame.ShowDialog();
            this.Close();
        }

        private void btnGuessNumber_Click(object sender, EventArgs e)
        {
            this.Hide();
            fGuessNumber.ShowDialog();
            this.Close();
        }
    }
}
