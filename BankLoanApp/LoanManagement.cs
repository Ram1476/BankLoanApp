using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoanApp
{
    public class LoanManagement
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public long AccNo { get; set; }
        public long Contactno { get; set; }
        public string Status { get; set; }
        public long income { get; set; }
        public long lAmt { get; set; }
        public string lType { get; set; }

        public string Eligible { get; set; }
    }

    public class LoanEligibility 
    {
        public void CheckStatus() 
        {

        }
    }
}
