namespace Homework7
{
    partial class fGuessNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGuessNumber));
            this.tbUserAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountTry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendAnswer = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUserAnswer
            // 
            this.tbUserAnswer.Location = new System.Drawing.Point(131, 250);
            this.tbUserAnswer.Name = "tbUserAnswer";
            this.tbUserAnswer.Size = new System.Drawing.Size(49, 20);
            this.tbUserAnswer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "I’ve got a number between 1 and 100!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(177, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Try to guess!";
            // 
            // lblCountTry
            // 
            this.lblCountTry.AutoSize = true;
            this.lblCountTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCountTry.Location = new System.Drawing.Point(325, 185);
            this.lblCountTry.Name = "lblCountTry";
            this.lblCountTry.Size = new System.Drawing.Size(25, 25);
            this.lblCountTry.TabIndex = 3;
            this.lblCountTry.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(126, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Remaining tries:";
            // 
            // btnSendAnswer
            // 
            this.btnSendAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSendAnswer.Location = new System.Drawing.Point(248, 238);
            this.btnSendAnswer.Name = "btnSendAnswer";
            this.btnSendAnswer.Size = new System.Drawing.Size(142, 40);
            this.btnSendAnswer.TabIndex = 5;
            this.btnSendAnswer.Text = "Send Answer";
            this.btnSendAnswer.UseVisualStyleBackColor = true;
            this.btnSendAnswer.Click += new System.EventHandler(this.btnSendAnswer_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.Location = new System.Drawing.Point(192, 125);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(117, 39);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "New Geme";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // fGuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnSendAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCountTry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserAnswer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "fGuessNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess Number";
            this.Shown += new System.EventHandler(this.fGuessNumber_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGuessNumber_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountTry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendAnswer;
        private System.Windows.Forms.Button btnNewGame;
    }
}