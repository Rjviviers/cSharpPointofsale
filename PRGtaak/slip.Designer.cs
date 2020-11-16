namespace PRGtaak
{
    partial class Slip
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.Psdayment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblchange = new System.Windows.Forms.Label();
            this.btnpay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(46, 56);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(46, 122);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 20);
            this.txtPayment.TabIndex = 0;
            // 
            // Psdayment
            // 
            this.Psdayment.AutoSize = true;
            this.Psdayment.Location = new System.Drawing.Point(43, 96);
            this.Psdayment.Name = "Psdayment";
            this.Psdayment.Size = new System.Drawing.Size(48, 13);
            this.Psdayment.TabIndex = 1;
            this.Psdayment.Text = "Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Change";
            // 
            // lblchange
            // 
            this.lblchange.AutoSize = true;
            this.lblchange.Location = new System.Drawing.Point(43, 183);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(10, 13);
            this.lblchange.TabIndex = 1;
            this.lblchange.Text = " ";
            // 
            // btnpay
            // 
            this.btnpay.Location = new System.Drawing.Point(46, 199);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(75, 23);
            this.btnpay.TabIndex = 2;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Slip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.lblchange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Psdayment);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Name = "Slip";
            this.Text = "Slip";
            this.Load += new System.EventHandler(this.Slip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label Psdayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblchange;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Button button1;
    }
}