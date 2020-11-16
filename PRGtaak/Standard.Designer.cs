namespace PRGtaak
{
    partial class Standard
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
            this.lstFood = new System.Windows.Forms.ListBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.tball = new System.Windows.Forms.TabControl();
            this.tabfood = new System.Windows.Forms.TabPage();
            this.tabDrink = new System.Windows.Forms.TabPage();
            this.lstDrink = new System.Windows.Forms.ListBox();
            this.tabother = new System.Windows.Forms.TabPage();
            this.lstOther = new System.Windows.Forms.ListBox();
            this.btncheckout = new System.Windows.Forms.Button();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.tball.SuspendLayout();
            this.tabfood.SuspendLayout();
            this.tabDrink.SuspendLayout();
            this.tabother.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFood
            // 
            this.lstFood.FormattingEnabled = true;
            this.lstFood.Location = new System.Drawing.Point(-4, -3);
            this.lstFood.Name = "lstFood";
            this.lstFood.Size = new System.Drawing.Size(225, 459);
            this.lstFood.TabIndex = 0;
            this.lstFood.SelectedIndexChanged += new System.EventHandler(this.lstFood_SelectedIndexChanged);
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(505, 31);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(245, 368);
            this.lstCart.TabIndex = 3;
            this.lstCart.SelectedIndexChanged += new System.EventHandler(this.lstCart_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtmax);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.nmQuantity);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.txtType);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtDesc);
            this.groupBox3.Location = new System.Drawing.Point(270, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 291);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "max";
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(10, 236);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(184, 20);
            this.txtmax.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "add to cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price per unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Description";
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(10, 193);
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(185, 20);
            this.nmQuantity.TabIndex = 1;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.ValueChanged += new System.EventHandler(this.nmQuantity_ValueChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(10, 153);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(185, 20);
            this.txtPrice.TabIndex = 0;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(10, 114);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(185, 20);
            this.txtType.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(10, 37);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(185, 20);
            this.txtDesc.TabIndex = 0;
            // 
            // tball
            // 
            this.tball.Controls.Add(this.tabfood);
            this.tball.Controls.Add(this.tabDrink);
            this.tball.Controls.Add(this.tabother);
            this.tball.Location = new System.Drawing.Point(23, 12);
            this.tball.Name = "tball";
            this.tball.SelectedIndex = 0;
            this.tball.Size = new System.Drawing.Size(225, 478);
            this.tball.TabIndex = 5;
            // 
            // tabfood
            // 
            this.tabfood.Controls.Add(this.lstFood);
            this.tabfood.Location = new System.Drawing.Point(4, 22);
            this.tabfood.Name = "tabfood";
            this.tabfood.Padding = new System.Windows.Forms.Padding(3);
            this.tabfood.Size = new System.Drawing.Size(217, 452);
            this.tabfood.TabIndex = 0;
            this.tabfood.Text = "Food";
            this.tabfood.UseVisualStyleBackColor = true;
            // 
            // tabDrink
            // 
            this.tabDrink.Controls.Add(this.lstDrink);
            this.tabDrink.Location = new System.Drawing.Point(4, 22);
            this.tabDrink.Name = "tabDrink";
            this.tabDrink.Padding = new System.Windows.Forms.Padding(3);
            this.tabDrink.Size = new System.Drawing.Size(217, 452);
            this.tabDrink.TabIndex = 1;
            this.tabDrink.Text = "Drink";
            this.tabDrink.UseVisualStyleBackColor = true;
            // 
            // lstDrink
            // 
            this.lstDrink.FormattingEnabled = true;
            this.lstDrink.Location = new System.Drawing.Point(-4, 0);
            this.lstDrink.Name = "lstDrink";
            this.lstDrink.Size = new System.Drawing.Size(225, 459);
            this.lstDrink.TabIndex = 0;
            this.lstDrink.SelectedIndexChanged += new System.EventHandler(this.lstDrink_SelectedIndexChanged);
            // 
            // tabother
            // 
            this.tabother.Controls.Add(this.lstOther);
            this.tabother.Location = new System.Drawing.Point(4, 22);
            this.tabother.Name = "tabother";
            this.tabother.Size = new System.Drawing.Size(217, 452);
            this.tabother.TabIndex = 2;
            this.tabother.Text = "other";
            this.tabother.UseVisualStyleBackColor = true;
            // 
            // lstOther
            // 
            this.lstOther.FormattingEnabled = true;
            this.lstOther.Location = new System.Drawing.Point(-4, 1);
            this.lstOther.Name = "lstOther";
            this.lstOther.Size = new System.Drawing.Size(221, 459);
            this.lstOther.TabIndex = 0;
            this.lstOther.SelectedIndexChanged += new System.EventHandler(this.lstOther_SelectedIndexChanged);
            // 
            // btncheckout
            // 
            this.btncheckout.Location = new System.Drawing.Point(675, 480);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(75, 23);
            this.btncheckout.TabIndex = 6;
            this.btncheckout.Text = "checkout";
            this.btncheckout.UseVisualStyleBackColor = true;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(505, 454);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(245, 20);
            this.txtTot.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Tax";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(505, 417);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(245, 20);
            this.txtTax.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total";
            // 
            // Standard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 513);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.btncheckout);
            this.Controls.Add(this.tball);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lstCart);
            this.Name = "Standard";
            this.Text = "Standard";
            this.Load += new System.EventHandler(this.Standard_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.tball.ResumeLayout(false);
            this.tabfood.ResumeLayout(false);
            this.tabDrink.ResumeLayout(false);
            this.tabother.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFood;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.TabControl tball;
        private System.Windows.Forms.TabPage tabfood;
        private System.Windows.Forms.TabPage tabDrink;
        private System.Windows.Forms.TabPage tabother;
        private System.Windows.Forms.ListBox lstDrink;
        private System.Windows.Forms.ListBox lstOther;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label8;
    }
}