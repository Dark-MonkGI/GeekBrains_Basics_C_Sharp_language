namespace Homework7
{
    partial class fSelectGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSelectGame));
            this.btnDoubler = new System.Windows.Forms.Button();
            this.btnGuessNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoubler
            // 
            this.btnDoubler.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoubler.Location = new System.Drawing.Point(139, 78);
            this.btnDoubler.Name = "btnDoubler";
            this.btnDoubler.Size = new System.Drawing.Size(223, 87);
            this.btnDoubler.TabIndex = 0;
            this.btnDoubler.Text = "Doubler";
            this.btnDoubler.UseVisualStyleBackColor = true;
            this.btnDoubler.Click += new System.EventHandler(this.btnDoubler_Click);
            // 
            // btnGuessNumber
            // 
            this.btnGuessNumber.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessNumber.Location = new System.Drawing.Point(139, 189);
            this.btnGuessNumber.Name = "btnGuessNumber";
            this.btnGuessNumber.Size = new System.Drawing.Size(223, 87);
            this.btnGuessNumber.TabIndex = 1;
            this.btnGuessNumber.Text = "Guess Number";
            this.btnGuessNumber.UseVisualStyleBackColor = true;
            this.btnGuessNumber.Click += new System.EventHandler(this.btnGuessNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(94, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "What game are we playing?";
            // 
            // fSelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuessNumber);
            this.Controls.Add(this.btnDoubler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "fSelectGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoubler;
        private System.Windows.Forms.Button btnGuessNumber;
        private System.Windows.Forms.Label label1;
    }
}