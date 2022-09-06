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
    public partial class fTrueFalseEditor : Form
    {
        TrueFalseEngine engine;

        public fTrueFalseEditor()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                engine = new TrueFalseEngine(dlg.FileName);
                engine.Add("Замля круглая?", true);
                engine.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
            cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                engine = new TrueFalseEngine(dlg.FileName);
                engine.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = engine.Count;
                nudNumber.Value = 1;
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            engine.Save();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            engine.Add($"#{engine.Count + 1}", true);
            nudNumber.Maximum = engine.Count;
            nudNumber.Value = engine.Count;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            engine[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            engine[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            engine.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum--;
            nudNumber.Value--;
        }
    }
}
