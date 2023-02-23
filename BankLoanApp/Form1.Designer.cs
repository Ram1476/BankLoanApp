namespace BankLoanApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAccno = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCon = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.LblLAMO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLAmt = new System.Windows.Forms.TextBox();
            this.LblTyp = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.chcklstStat = new System.Windows.Forms.CheckedListBox();
            this.bankingDataSet = new BankLoanApp.BankingDataSet();
            this.bankingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DisplayGrid = new System.Windows.Forms.DataGridView();
            this.CmbLoanType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.BackColor = System.Drawing.Color.CadetBlue;
            this.lblHead.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(398, 42);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(260, 25);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Bank Loan Application";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(163, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Customer-Name : ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 166);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(129, 24);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Customer-ID : ";
            // 
            // lblAccno
            // 
            this.lblAccno.AutoSize = true;
            this.lblAccno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccno.Location = new System.Drawing.Point(12, 214);
            this.lblAccno.Name = "lblAccno";
            this.lblAccno.Size = new System.Drawing.Size(175, 24);
            this.lblAccno.TabIndex = 3;
            this.lblAccno.Text = "Customer-Acc.No : ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(217, 117);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 30);
            this.txtName.TabIndex = 4;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(12, 269);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(204, 24);
            this.lblCon.TabIndex = 5;
            this.lblCon.Text = "Customer Contact No : ";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(217, 169);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(265, 30);
            this.txtID.TabIndex = 6;
            // 
            // txtAccNo
            // 
            this.txtAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNo.Location = new System.Drawing.Point(217, 217);
            this.txtAccNo.Multiline = true;
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(265, 31);
            this.txtAccNo.TabIndex = 7;
            // 
            // txtCon
            // 
            this.txtCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon.Location = new System.Drawing.Point(217, 268);
            this.txtCon.Multiline = true;
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(265, 34);
            this.txtCon.TabIndex = 8;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.Location = new System.Drawing.Point(565, 175);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(161, 24);
            this.lblIncome.TabIndex = 9;
            this.lblIncome.Text = "Current - Income :";
            // 
            // txtIncome
            // 
            this.txtIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(779, 166);
            this.txtIncome.Multiline = true;
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(265, 30);
            this.txtIncome.TabIndex = 10;
            // 
            // LblLAMO
            // 
            this.LblLAMO.AutoSize = true;
            this.LblLAMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLAMO.Location = new System.Drawing.Point(565, 224);
            this.LblLAMO.Name = "LblLAMO";
            this.LblLAMO.Size = new System.Drawing.Size(133, 24);
            this.LblLAMO.TabIndex = 14;
            this.LblLAMO.Text = "Loan Amount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Employment - status :";
            // 
            // txtLAmt
            // 
            this.txtLAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLAmt.Location = new System.Drawing.Point(779, 218);
            this.txtLAmt.Multiline = true;
            this.txtLAmt.Name = "txtLAmt";
            this.txtLAmt.Size = new System.Drawing.Size(265, 30);
            this.txtLAmt.TabIndex = 19;
            // 
            // LblTyp
            // 
            this.LblTyp.AutoSize = true;
            this.LblTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTyp.Location = new System.Drawing.Point(565, 269);
            this.LblTyp.Name = "LblTyp";
            this.LblTyp.Size = new System.Drawing.Size(110, 24);
            this.LblTyp.TabIndex = 20;
            this.LblTyp.Text = "Loan Type :";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(474, 322);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(138, 40);
            this.btnCheck.TabIndex = 23;
            this.btnCheck.Text = "Check Eligibility";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // chcklstStat
            // 
            this.chcklstStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcklstStat.FormattingEnabled = true;
            this.chcklstStat.Items.AddRange(new object[] {
            "Active",
            "In Active"});
            this.chcklstStat.Location = new System.Drawing.Point(779, 123);
            this.chcklstStat.Name = "chcklstStat";
            this.chcklstStat.Size = new System.Drawing.Size(111, 25);
            this.chcklstStat.TabIndex = 27;
            // 
            // bankingDataSet
            // 
            this.bankingDataSet.DataSetName = "BankingDataSet";
            this.bankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankingDataSetBindingSource
            // 
            this.bankingDataSetBindingSource.DataSource = this.bankingDataSet;
            this.bankingDataSetBindingSource.Position = 0;
            // 
            // DisplayGrid
            // 
            this.DisplayGrid.AutoGenerateColumns = false;
            this.DisplayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayGrid.DataSource = this.bankingDataSetBindingSource;
            this.DisplayGrid.Location = new System.Drawing.Point(87, 381);
            this.DisplayGrid.Name = "DisplayGrid";
            this.DisplayGrid.ReadOnly = true;
            this.DisplayGrid.Size = new System.Drawing.Size(894, 213);
            this.DisplayGrid.TabIndex = 29;
            // 
            // CmbLoanType
            // 
            this.CmbLoanType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbLoanType.FormattingEnabled = true;
            this.CmbLoanType.Items.AddRange(new object[] {
            "Home Loan",
            "Car Loan",
            "Educational Loan",
            "Business Loan"});
            this.CmbLoanType.Location = new System.Drawing.Point(779, 274);
            this.CmbLoanType.Name = "CmbLoanType";
            this.CmbLoanType.Size = new System.Drawing.Size(168, 28);
            this.CmbLoanType.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1099, 619);
            this.Controls.Add(this.CmbLoanType);
            this.Controls.Add(this.DisplayGrid);
            this.Controls.Add(this.chcklstStat);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.LblTyp);
            this.Controls.Add(this.txtLAmt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblLAMO);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAccno);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHead);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAccno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label LblLAMO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLAmt;
        private System.Windows.Forms.Label LblTyp;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.CheckedListBox chcklstStat;
        private System.Windows.Forms.BindingSource bankingDataSetBindingSource;
        private BankingDataSet bankingDataSet;
        private System.Windows.Forms.DataGridView DisplayGrid;
        private System.Windows.Forms.ComboBox CmbLoanType;
    }
}

