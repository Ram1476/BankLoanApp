namespace CheckCondition
{
    partial class checker1
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
            this.btnChckEli = new System.Windows.Forms.Button();
            this.lblinc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChckEli
            // 
            this.btnChckEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChckEli.Location = new System.Drawing.Point(59, 435);
            this.btnChckEli.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnChckEli.Name = "btnChckEli";
            this.btnChckEli.Size = new System.Drawing.Size(157, 36);
            this.btnChckEli.TabIndex = 0;
            this.btnChckEli.Text = "Check Tenure";
            this.btnChckEli.UseVisualStyleBackColor = true;
            // 
            // lblinc
            // 
            this.lblinc.AutoSize = true;
            this.lblinc.Location = new System.Drawing.Point(55, 82);
            this.lblinc.Name = "lblinc";
            this.lblinc.Size = new System.Drawing.Size(150, 20);
            this.lblinc.TabIndex = 1;
            this.lblinc.Text = "Annual - Income :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 26);
            this.textBox1.TabIndex = 2;
            // 
            // checker1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(660, 515);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblinc);
            this.Controls.Add(this.btnChckEli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "checker1";
            this.Text = "Eligibility Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChckEli;
        private System.Windows.Forms.Label lblinc;
        private System.Windows.Forms.TextBox textBox1;
    }
}

