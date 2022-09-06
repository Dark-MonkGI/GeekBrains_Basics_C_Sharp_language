using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class fMain : Form
    {
        fTrueFalseEditor fTrueFalseEditor = new fTrueFalseEditor();
        int tic = 0;

        public fMain()
        {
            InitializeComponent();
        }

        private void btnNo_Click_1(object sender, EventArgs e)
        {
            ClosedBye();
        }

        private void btnGo_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            fTrueFalseEditor.ShowDialog();
            this.Show();
            ClosedBye();
        }

        private void ClosedBye()
        {
            btnGo.Visible = false;
            btnNo.Visible = false;
            lblSayHi.Visible = false;
            lblLetsPay.Left = 125;
            lblLetsPay.Text = "Ok...Bye! See you...";
            lblLetsPay.Refresh();
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
