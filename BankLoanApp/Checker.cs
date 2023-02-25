using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLoanApp
{
    public partial class Checker : Form
    {
        public Checker(string s)
        {
            InitializeComponent();
            txtLoanAmt.Text = s;
        }
        LoanManagement user = new LoanManagement();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEmi_Click(object sender, EventArgs e)
        {
            //(P * R * (1+R) ^ N ) / [(1+R)^N-1]
            double P;
            double.TryParse(txtLoanAmt.Text, out P);
            double R;
            double.TryParse(txtInt.Text, out (R));
            double rm = Math.Round(((R / 12) / 100), 5);
            double N;
            double.TryParse(txtTenure.Text, out N);
            double Calculate;
            double Q = Math.Pow((1 + rm), N);
            double dow = (Q - 1);
            double divide = Q / dow;
            Calculate = P * rm * (divide);
            txtCal.Text = "$"+" "+ (Math.Round(Calculate)).ToString();
            double total = Math.Round(Calculate * N);
            double intAmt = Math.Round((total - P));
            txtintAmt.Text = "$" + " " + intAmt.ToString();
            txtTotal.Text = "$" + " " + total.ToString();

        }

        private void lblLAmt_Click(object sender, EventArgs e)
        {

        }

        private void lblTenure_Click(object sender, EventArgs e)
        {

        }

        private void txtTenure_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPer_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }
    }
}
