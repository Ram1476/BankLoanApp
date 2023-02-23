using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Permissions;
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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-39SGDTH\\SQLEXPRESS;Initial Catalog=Banking;Integrated Security=True");
        LoanEligibility le = new LoanEligibility();
        private void chckStat2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            LoanManagement Customer1 = new LoanManagement();
            Customer1.id = Convert.ToInt32(txtID.Text);
            Customer1.name = txtName.Text;
            Customer1.accNo = Convert.ToInt64(txtAccNo.Text);
            Customer1.contactno = Convert.ToInt64(txtCon.Text);
            Customer1.income = Convert.ToInt64(txtIncome.Text);
            Customer1.lAmt = Convert.ToInt64(txtLAmt.Text);
            int len = (chcklstStat.CheckedIndices).Count;
            Customer1.lType = CmbLoanType.Text;
            
            try
            {
                if (len != 0)
                {
                    Customer1.Status = chcklstStat.CheckedItems[0].ToString();
                    if (le.CheckStatus(Customer1))
                    {
                        MessageBox.Show($"Based on your Income You are eligilbe for {Customer1.lType}");
                    }
                    else
                    {
                        MessageBox.Show($"Based on your Income you are not Eligible for {Customer1.lType}");
                    }
                    SqlCommand DA = new SqlCommand($"INSERT INTO\tcustomersDetails(cus_id,cus_name,cus_Acc_No,cus_Contact_no,Employment_Status" +
                        $",Current_Income,Loan_Amt,Loan_type,Eligibility)\r\nvalues('{Customer1.id}','{Customer1.name}',{Customer1.accNo},{Customer1.contactno},'{Customer1.Status.ToUpper()}',{Customer1.income},{Customer1.lAmt},'{Customer1.lType}','{Customer1.eligible}');", con);
                    con.Open();

                    DA.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer Detail Successfully Added to the Database");
                }
                else 
                {
                    Customer1.Status = "In Active";
                    if (le.CheckStatus(Customer1))
                    {
                        MessageBox.Show($"Based on your Income You are eligilbe for {Customer1.lType}");
                    }
                    else
                    {
                        MessageBox.Show($"Based on your Income you are not Eligible for {Customer1.lType}");
                    }
                    SqlCommand DA = new SqlCommand($"INSERT INTO\tcustomersDetails(cus_id,cus_name,cus_Acc_No,cus_Contact_no" +
                        $",Current_Income,Loan_Amt,Loan_type,Eligibility)\r\nvalues('{Customer1.id}','{Customer1.name}',{Customer1.accNo},{Customer1.contactno},{Customer1.income},{Customer1.lAmt},'{Customer1.lType}','{Customer1.eligible}');", con);
                    con.Open();

                    DA.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer Detail Successfully Added to the Database");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing Customer Details - Not added to the Database:"+ Environment.NewLine + ex.Message);
            }
             
            

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            DisplayGrid.Visible = true;

            try 
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from customersDetails where eligibility = 'Eligible for Loan';", con);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                da.Fill(ds, "customersDetails");
                DisplayGrid.DataSource = ds.Tables["customersDetails"].DefaultView;
                MessageBox.Show("Customer Details Successfully Displayed"); 
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Displaying the Customer's Details: " + Environment.NewLine + ex.Message);
            }
        }
    }
}
