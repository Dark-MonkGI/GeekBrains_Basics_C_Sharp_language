namespace Homework7
{
    partial class fGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.lblTextCurNum = new System.Windows.Forms.Label();
            this.lblTextGenNum = new System.Windows.Forms.Label();
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.btnDoubler = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblGenNum = new System.Windows.Forms.Label();
            this.lblCurNum = new System.Windows.Forms.Label();
            this.lblTextCountSteps = new System.Windows.Forms.Label();
            this.lblCountSteps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextCurNum
            // 
            this.lblTextCurNum.AutoSize = true;
            this.lblTextCurNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextCurNum.Location = new System.Drawing.Point(47, 164);
            this.lblTextCurNum.Name = "lblTextCurNum";
            this.lblTextCurNum.Size = new System.Drawing.Size(182, 25);
            this.lblTextCurNum.TabIndex = 9;
            this.lblTextCurNum.Text = "Current number:";
            // 
            // lblTextGenNum
            // 
            this.lblTextGenNum.AutoSize = true;
            this.lblTextGenNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextGenNum.Location = new System.Drawing.Point(47, 73);
            this.lblTextGenNum.Name = "lblTextGenNum";
            this.lblTextGenNum.Size = new System.Drawing.Size(214, 25);
            this.lblTextGenNum.TabIndex = 8;
            this.lblTextGenNum.Text = "Generated number:";
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlusOne.Location = new System.Drawing.Point(298, 195);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(127, 64);
            this.btnPlusOne.TabIndex = 7;
            this.btnPlusOne.Text = "+1";
            this.btnPlusOne.UseVisualStyleBackColor = true;
            this.btnPlusOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // btnDoubler
            // 
            this.btnDoubler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoubler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDoubler.Location = new System.Drawing.Point(298, 125);
            this.btnDoubler.Name = "btnDoubler";
            this.btnDoubler.Size = new System.Drawing.Size(127, 64);
            this.btnDoubler.TabIndex = 6;
            this.btnDoubler.Text = "x2";
            this.btnDoubler.UseVisualStyleBackColor = true;
            this.btnDoubler.Click += new System.EventHandler(this.btnDoubler_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(298, 55);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 64);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "New Game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblGenNum
            // 
            this.lblGenNum.AutoSize = true;
            this.lblGenNum.Location = new System.Drawing.Point(128, 125);
            this.lblGenNum.Name = "lblGenNum";
            this.lblGenNum.Size = new System.Drawing.Size(0, 13);
            this.lblGenNum.TabIndex = 10;
            // 
            // lblCurNum
            // 
            this.lblCurNum.AutoSize = true;
            this.lblCurNum.Location = new System.Drawing.Point(128, 222);
            this.lblCurNum.Name = "lblCurNum";
            this.lblCurNum.Size = new System.Drawing.Size(0, 13);
            this.lblCurNum.TabIndex = 11;
            // 
            // lblTextCountSteps
            // 
            this.lblTextCountSteps.AutoSize = true;
            this.lblTextCountSteps.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextCountSteps.Location = new System.Drawing.Point(52, 286);
            this.lblTextCountSteps.Name = "lblTextCountSteps";
            this.lblTextCountSteps.Size = new System.Drawing.Size(174, 15);
            this.lblTextCountSteps.TabIndex = 12;
            this.lblTextCountSteps.Text = "Remaining number of steps:";
            // 
            // lblCountSteps
            // 
            this.lblCountSteps.AutoSize = true;
            this.lblCountSteps.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold);
            this.lblCountSteps.Location = new System.Drawing.Point(232, 287);
            this.lblCountSteps.Name = "lblCountSteps";
            this.lblCountSteps.Size = new System.Drawing.Size(0, 15);
            this.lblCountSteps.TabIndex = 13;
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.lblCountSteps);
            this.Controls.Add(this.lblTextCountSteps);
            this.Controls.Add(this.lblCurNum);
            this.Controls.Add(this.lblGenNum);
            this.Controls.Add(this.lblTextCurNum);
            this.Controls.Add(this.lblTextGenNum);
            this.Controls.Add(this.btnPlusOne);
            this.Controls.Add(this.btnDoubler);
            this.Controls.Add(this.btnReset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "fGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubler";
            this.Shown += new System.EventHandler(this.fGame_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextCurNum;
        private System.Windows.Forms.Label lblTextGenNum;
        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.Button btnDoubler;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblGenNum;
        private System.Windows.Forms.Label lblCurNum;
        private System.Windows.Forms.Label lblTextCountSteps;
        private System.Windows.Forms.Label lblCountSteps;
    }
}

