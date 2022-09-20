namespace WinATMDemo
{
    partial class AccBalForm
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblAccNo = new System.Windows.Forms.Label();
            this.lblAccBal = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblac = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(365, 56);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(44, 16);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "label1";
            // 
            // lblAccNo
            // 
            this.lblAccNo.AutoSize = true;
            this.lblAccNo.Location = new System.Drawing.Point(365, 139);
            this.lblAccNo.Name = "lblAccNo";
            this.lblAccNo.Size = new System.Drawing.Size(44, 16);
            this.lblAccNo.TabIndex = 1;
            this.lblAccNo.Text = "label2";
            // 
            // lblAccBal
            // 
            this.lblAccBal.AutoSize = true;
            this.lblAccBal.Location = new System.Drawing.Point(365, 223);
            this.lblAccBal.Name = "lblAccBal";
            this.lblAccBal.Size = new System.Drawing.Size(44, 16);
            this.lblAccBal.TabIndex = 2;
            this.lblAccBal.Text = "label3";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(125, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Customer Name";
            // 
            // lblac
            // 
            this.lblac.AutoSize = true;
            this.lblac.Location = new System.Drawing.Point(157, 139);
            this.lblac.Name = "lblac";
            this.lblac.Size = new System.Drawing.Size(72, 16);
            this.lblac.TabIndex = 4;
            this.lblac.Text = "account no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "account balance";
            // 
            // AccBalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblac);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAccBal);
            this.Controls.Add(this.lblAccNo);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "AccBalForm";
            this.Text = "AccBalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblAccNo;
        private System.Windows.Forms.Label lblAccBal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblac;
        private System.Windows.Forms.Label label3;
    }
}