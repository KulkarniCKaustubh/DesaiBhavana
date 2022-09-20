namespace WinATMDemo
{
    partial class ATMEnter
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
            this.lblSelectChoice = new System.Windows.Forms.Label();
            this.btnCheckBal = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnStatement = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectChoice
            // 
            this.lblSelectChoice.AutoSize = true;
            this.lblSelectChoice.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectChoice.ForeColor = System.Drawing.Color.Crimson;
            this.lblSelectChoice.Location = new System.Drawing.Point(301, 30);
            this.lblSelectChoice.Name = "lblSelectChoice";
            this.lblSelectChoice.Size = new System.Drawing.Size(198, 25);
            this.lblSelectChoice.TabIndex = 0;
            this.lblSelectChoice.Text = "Select Your Choice";
            // 
            // btnCheckBal
            // 
            this.btnCheckBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBal.Location = new System.Drawing.Point(128, 104);
            this.btnCheckBal.Name = "btnCheckBal";
            this.btnCheckBal.Size = new System.Drawing.Size(130, 46);
            this.btnCheckBal.TabIndex = 1;
            this.btnCheckBal.Text = "Check Balance";
            this.btnCheckBal.UseVisualStyleBackColor = true;
            this.btnCheckBal.Click += new System.EventHandler(this.btnCheckBal_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(128, 213);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(130, 46);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Cash Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnStatement
            // 
            this.btnStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatement.Location = new System.Drawing.Point(510, 104);
            this.btnStatement.Name = "btnStatement";
            this.btnStatement.Size = new System.Drawing.Size(130, 46);
            this.btnStatement.TabIndex = 3;
            this.btnStatement.Text = "Mini Statement";
            this.btnStatement.UseVisualStyleBackColor = true;
            this.btnStatement.Click += new System.EventHandler(this.btnStatement_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(510, 213);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ATMEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStatement);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnCheckBal);
            this.Controls.Add(this.lblSelectChoice);
            this.Name = "ATMEnter";
            this.Text = "ATMEnter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectChoice;
        private System.Windows.Forms.Button btnCheckBal;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnStatement;
        private System.Windows.Forms.Button btnExit;
    }
}