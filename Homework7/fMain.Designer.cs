namespace Homework7
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.lblSayHi = new System.Windows.Forms.Label();
            this.lblLetsPay = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayHi
            // 
            this.lblSayHi.AutoSize = true;
            this.lblSayHi.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayHi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSayHi.Location = new System.Drawing.Point(87, 9);
            this.lblSayHi.Name = "lblSayHi";
            this.lblSayHi.Size = new System.Drawing.Size(295, 112);
            this.lblSayHi.TabIndex = 0;
            this.lblSayHi.Text = "================================\r\n\r\n  Hello my teacher, Stanislav!\r\n    My name i" +
    "s Ilya!\r\nThis is my homework number: 7\r\n\r\n================================";
            this.lblSayHi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetsPay
            // 
            this.lblLetsPay.AutoSize = true;
            this.lblLetsPay.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetsPay.Location = new System.Drawing.Point(183, 149);
            this.lblLetsPay.Name = "lblLetsPay";
            this.lblLetsPay.Size = new System.Drawing.Size(123, 33);
            this.lblLetsPay.TabIndex = 1;
            this.lblLetsPay.Text = "Let\'s Play?";
            this.lblLetsPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Papyrus", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(90, 221);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(99, 39);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Papyrus", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnNo.Location = new System.Drawing.Point(283, 221);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(99, 39);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "Nope";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblLetsPay);
            this.Controls.Add(this.lblSayHi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayHi;
        private System.Windows.Forms.Label lblLetsPay;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnNo;
    }
}