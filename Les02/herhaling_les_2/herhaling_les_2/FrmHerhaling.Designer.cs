namespace herhaling_les_2
{
    partial class FrmHerhaling
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHello = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.txtSwap2 = new System.Windows.Forms.TextBox();
            this.txtSwap1 = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.txtDiscountPercentage = new System.Windows.Forms.TextBox();
            this.txtOriginalPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtHello
            // 
            this.txtHello.Location = new System.Drawing.Point(225, 16);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(100, 20);
            this.txtHello.TabIndex = 1;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(119, 13);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(100, 23);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "zeg hallo";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(119, 60);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(100, 23);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "wisselen ";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // txtSwap2
            // 
            this.txtSwap2.Location = new System.Drawing.Point(225, 63);
            this.txtSwap2.Name = "txtSwap2";
            this.txtSwap2.Size = new System.Drawing.Size(100, 20);
            this.txtSwap2.TabIndex = 4;
            // 
            // txtSwap1
            // 
            this.txtSwap1.Location = new System.Drawing.Point(13, 62);
            this.txtSwap1.Name = "txtSwap1";
            this.txtSwap1.Size = new System.Drawing.Size(100, 20);
            this.txtSwap1.TabIndex = 3;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(119, 98);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(100, 23);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "delen";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(225, 101);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 7;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(13, 100);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(345, 103);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 9;
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(345, 142);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(0, 13);
            this.lblFinalPrice.TabIndex = 13;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(119, 137);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(100, 23);
            this.btnDiscount.TabIndex = 12;
            this.btnDiscount.Text = "korting";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.Location = new System.Drawing.Point(225, 140);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountPercentage.TabIndex = 11;
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Location = new System.Drawing.Point(13, 139);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtOriginalPrice.TabIndex = 10;
            // 
            // FrmHerhaling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 180);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.txtDiscountPercentage);
            this.Controls.Add(this.txtOriginalPrice);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.txtSwap2);
            this.Controls.Add(this.txtSwap1);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtHello);
            this.Controls.Add(this.txtName);
            this.Name = "FrmHerhaling";
            this.Text = "Herhaling Les 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHello;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.TextBox txtSwap2;
        private System.Windows.Forms.TextBox txtSwap1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.TextBox txtDiscountPercentage;
        private System.Windows.Forms.TextBox txtOriginalPrice;
    }
}

