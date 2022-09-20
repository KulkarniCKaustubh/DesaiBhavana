namespace WinATMDemo
{
    partial class ATMDemo
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(307, 23);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(190, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome To ATM";
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNo.Location = new System.Drawing.Point(214, 98);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(111, 22);
            this.lblCardNo.TabIndex = 1;
            this.lblCardNo.Text = "Enter Card No.";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(252, 169);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(73, 22);
            this.lblPin.TabIndex = 2;
            this.lblPin.Text = "Enter Pin";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(424, 98);
            this.txtCardNo.MaxLength = 16;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(202, 22);
            this.txtCardNo.TabIndex = 3;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(424, 169);
            this.txtPin.MaxLength = 4;
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(202, 22);
            this.txtPin.TabIndex = 4;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(256, 253);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(108, 33);
            this.btnVerify.TabIndex = 5;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(490, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ATMDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblCardNo);
            this.Controls.Add(this.lblWelcome);
            this.Name = "ATMDemo";
            this.Text = "ATMDemo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ATMDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnCancel;
    }
}

