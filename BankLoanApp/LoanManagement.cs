using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoanApp
{
    public class LoanManagement
    {
        public string name { get; set; }
        public int id { get; set; }
        public long accNo { get; set; }
        public long contactno { get; set; }
        public string Status { get; set; }
        public long income { get; set; }
        public long lAmt { get; set; }
        public string lType { get; set; }

        public string eligible { get; set; }
    }

    public class LoanEligibility 
    {
        public bool CheckStatus(LoanManagement cus)
        {
            LoanManagement entry1 = cus;
            bool isSuccess = false;
            if (entry1.Status.ToLower() == "active")
            {
                switch (entry1.lType.ToLower())
                {

                    case "home loan":
                        if (entry1.income > 500000)
                        {
                            entry1.eligible = "Eligible for Loan";
                            isSuccess = true;
                        }
                        else
                        {
                            entry1.eligible = "Not Eligible for Home Loan";
                            isSuccess = false;
                        }
                        break;

                    case "car loan":
                        if (entry1.income > 1000000)
                        {
                            entry1.eligible = "Eligible for Loan";
                            isSuccess = true;
                        }
                        else
                        {
                            entry1.eligible = "Not Eligible for Car Loan";
                            isSuccess = false;
                        }
                        break;

                    case "personal loan":
                        if (entry1.income >= 500000)
                        {
                            entry1.eligible = "Eligible for Loan";
                            isSuccess = true;
                        }
                        else
                        {
                            entry1.eligible = "Not Eligible for Home Loan";
                            isSuccess = false;
                        }
                        break;

                    case "business loan":
                        if (entry1.income > 1000000)
                        {
                            entry1.eligible = "Eligible for Loan";
                            isSuccess = true;
                        }
                        else
                        {
                            entry1.eligible = "Not Eligible for Home Loan";
                            isSuccess = false;
                        }
                        break;
                }
            }
            else 
            {
                entry1.eligible = "Not Eligible For Any loan";
                isSuccess = false;
            }
            return isSuccess;
        }
    }
}
