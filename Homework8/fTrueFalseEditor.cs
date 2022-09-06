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
        int currentValueNud = 1;

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
                engine.Add("Земля круглая?", true);
                engine.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {

            if (engine != null)
            {
                if(currentValueNud != (int)nudNumber.Value)
                {
                    SaveEngine(currentValueNud - 1);
                    currentValueNud = (int)nudNumber.Value;
                }

                tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
            }
            else
                nudNumber.Value = 0;
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
            SaveEngineFile();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (engine != null)
            {
                engine.Add($"#{engine.Count + 1}", true);
                nudNumber.Maximum = engine.Count;
                nudNumber.Value = engine.Count;
            }
            else
                MessageBox.Show("Файл не инициализирован\n\r Сперва создайте файл", "TrueFalse Editor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEngineFile();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (engine != null)
            {
                engine.Remove((int)nudNumber.Value - 1);
                nudNumber.Maximum--;
                nudNumber.Value--;

                SaveEngineFile();
            }
            else
                MessageBox.Show("Файл не инициализирован\n\r Сперва создайте файл", "TrueFalse Editor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void SaveEngine()
        {
            if (engine != null)
            {
                engine[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                engine[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
            }
            else
                MessageBox.Show("Файл не инициализирован\n\r Сперва создайте файл", "TrueFalse Editor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SaveEngine(int num)
        {
            if (engine != null)
            {
                engine[num].Text = tbQuestion.Text;
                engine[num].TrueFalse = cbTrue.Checked;
            }
            else
                MessageBox.Show("Файл не инициализирован\n\r Сперва создайте файл", "TrueFalse Editor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SaveEngineFile()
        {
            if (engine != null)
            {
                SaveEngine();

                engine.Save();
            }
            else
                MessageBox.Show("Файл не инициализирован\n\r Сперва создайте файл", "TrueFalse Editor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
