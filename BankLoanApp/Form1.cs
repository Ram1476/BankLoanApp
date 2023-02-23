using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLoanApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayGrid.Visible = false;
        }
        
        private void chckStat2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DisplayGrid.Visible = true;
            LoanManagement Customer1 = new LoanManagement();
            Customer1.ID = Convert.ToInt32(txtID.Text);
            Customer1.Name = txtName.Text;
            Customer1.AccNo = Convert.ToInt64(txtAccNo.Text);
            Customer1.Contactno = Convert.ToInt64(txtCon.Text);
            Customer1.income = Convert.ToInt64(txtIncome.Text);
            Customer1.lAmt = Convert.ToInt64(txtLAmt.Text);
            try 
            {
                Customer1.Status = chcklstStat.CheckedItems[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a Valid Value for the Employee Status" + Environment.NewLine + ex.Message);
            }
           
            Customer1.lType = CmbLoanType.Text;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=NLTI151\\SQLEXPRESS;Initial Catalog=Banking;Integrated Security=True");

                SqlCommand DA = new SqlCommand($"INSERT INTO\tcustomerDetails(cus_id,cus_name,cus_Acc_No,cus_Contact_no,Employment_Status" +
                    $",Current_Income,Loan_Amount,Loan_type,Eligibility)\r\nvalues('{Customer1.ID}','{Customer1.Name}',{Customer1.AccNo},{Customer1.Contactno},'{Customer1.Status}',{Customer1.income},{Customer1.lAmt},'{Customer1.lType}','{Customer1.Eligible}');",con);
                con.Open();

                DA.ExecuteNonQuery(); 
                con.Close();
                SqlDataAdapter da = new SqlDataAdapter("select * from customerDetails",con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                //string s = " ";
                //foreach(DataRow dr in dt.Rows) 
                //{
                //    s+= dr[0].ToString() + "|" + dr[1].ToString() + "|" + dr[2].ToString() + "|" + dr[3].ToString() + "|" + dr[4].ToString() + "|" + dr[5].ToString()
                //        + "|" + dr[6].ToString() + "|" + dr[7].ToString() + "|" + dr[8].ToString()+"\r\n";
                //}
               DisplayGrid.DataSource = dt;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}
