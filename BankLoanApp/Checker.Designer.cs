namespace BankLoanApp
{
    partial class Checker
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLAmt = new System.Windows.Forms.Label();
            this.lblTenure = new System.Windows.Forms.Label();
            this.txtLoanAmt = new System.Windows.Forms.TextBox();
            this.txtTenure = new System.Windows.Forms.TextBox();
            this.lblPer = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.btnEmi = new System.Windows.Forms.Button();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.lblEMIPM = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.txtintAmt = new System.Windows.Forms.TextBox();
            this.lblIntAmt = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loan EMI Calculator";
            // 
            // lblLAmt
            // 
            this.lblLAmt.AutoSize = true;
            this.lblLAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLAmt.Location = new System.Drawing.Point(48, 110);
            this.lblLAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLAmt.Name = "lblLAmt";
            this.lblLAmt.Size = new System.Drawing.Size(146, 24);
            this.lblLAmt.TabIndex = 3;
            this.lblLAmt.Text = "Loan Amount :";
            this.lblLAmt.Click += new System.EventHandler(this.lblLAmt_Click);
            // 
            // lblTenure
            // 
            this.lblTenure.AutoSize = true;
            this.lblTenure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenure.Location = new System.Drawing.Point(48, 170);
            this.lblTenure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenure.Name = "lblTenure";
            this.lblTenure.Size = new System.Drawing.Size(187, 24);
            this.lblTenure.TabIndex = 4;
            this.lblTenure.Text = "Tenure in Months :";
            this.lblTenure.Click += new System.EventHandler(this.lblTenure_Click);
            // 
            // txtLoanAmt
            // 
            this.txtLoanAmt.Location = new System.Drawing.Point(263, 110);
            this.txtLoanAmt.Name = "txtLoanAmt";
            this.txtLoanAmt.Size = new System.Drawing.Size(162, 26);
            this.txtLoanAmt.TabIndex = 5;
            // 
            // txtTenure
            // 
            this.txtTenure.Location = new System.Drawing.Point(263, 170);
            this.txtTenure.Name = "txtTenure";
            this.txtTenure.Size = new System.Drawing.Size(162, 26);
            this.txtTenure.TabIndex = 6;
            this.txtTenure.TextChanged += new System.EventHandler(this.txtTenure_TextChanged);
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.Location = new System.Drawing.Point(48, 236);
            this.lblPer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(187, 24);
            this.lblPer.TabIndex = 7;
            this.lblPer.Text = "Interest Rate (p.a) :";
            this.lblPer.Click += new System.EventHandler(this.lblPer_Click);
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(263, 236);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(162, 26);
            this.txtInt.TabIndex = 8;
            this.txtInt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEmi
            // 
            this.btnEmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmi.Location = new System.Drawing.Point(263, 533);
            this.btnEmi.Name = "btnEmi";
            this.btnEmi.Size = new System.Drawing.Size(149, 37);
            this.btnEmi.TabIndex = 9;
            this.btnEmi.Text = "Calculate";
            this.btnEmi.UseVisualStyleBackColor = true;
            this.btnEmi.Click += new System.EventHandler(this.btnEmi_Click);
            // 
            // txtCal
            // 
            this.txtCal.Location = new System.Drawing.Point(263, 302);
            this.txtCal.Multiline = true;
            this.txtCal.Name = "txtCal";
            this.txtCal.ReadOnly = true;
            this.txtCal.Size = new System.Drawing.Size(162, 37);
            this.txtCal.TabIndex = 10;
            // 
            // lblEMIPM
            // 
            this.lblEMIPM.AutoSize = true;
            this.lblEMIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMIPM.Location = new System.Drawing.Point(48, 315);
            this.lblEMIPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEMIPM.Name = "lblEMIPM";
            this.lblEMIPM.Size = new System.Drawing.Size(159, 24);
            this.lblEMIPM.TabIndex = 11;
            this.lblEMIPM.Text = "EMI per month :";
            this.lblEMIPM.Click += new System.EventHandler(this.lblText_Click);
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(447, 238);
            this.lblInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(26, 24);
            this.lblInterest.TabIndex = 12;
            this.lblInterest.Text = "%";
            // 
            // txtintAmt
            // 
            this.txtintAmt.Location = new System.Drawing.Point(263, 372);
            this.txtintAmt.Multiline = true;
            this.txtintAmt.Name = "txtintAmt";
            this.txtintAmt.ReadOnly = true;
            this.txtintAmt.Size = new System.Drawing.Size(162, 37);
            this.txtintAmt.TabIndex = 13;
            // 
            // lblIntAmt
            // 
            this.lblIntAmt.AutoSize = true;
            this.lblIntAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntAmt.Location = new System.Drawing.Point(48, 385);
            this.lblIntAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntAmt.Name = "lblIntAmt";
            this.lblIntAmt.Size = new System.Drawing.Size(168, 24);
            this.lblIntAmt.TabIndex = 14;
            this.lblIntAmt.Text = "Interest Amount :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(263, 438);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(162, 37);
            this.txtTotal.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(48, 451);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(146, 24);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total Amount :";
            // 
            // Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(747, 645);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblIntAmt);
            this.Controls.Add(this.txtintAmt);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblEMIPM);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.btnEmi);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.txtTenure);
            this.Controls.Add(this.txtLoanAmt);
            this.Controls.Add(this.lblTenure);
            this.Controls.Add(this.lblLAmt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Checker";
            this.Text = "Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLAmt;
        private System.Windows.Forms.Label lblTenure;
        private System.Windows.Forms.TextBox txtLoanAmt;
        private System.Windows.Forms.TextBox txtTenure;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.Button btnEmi;
        private System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.Label lblEMIPM;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.TextBox txtintAmt;
        private System.Windows.Forms.Label lblIntAmt;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}