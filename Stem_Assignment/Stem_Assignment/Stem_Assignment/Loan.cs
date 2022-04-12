using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stem_Assignment
{
    class Loan
    {
        public string CustomerNumber { get; set; }
        public float LoanAmount { get; set; }
        public DateTime DateIssued { get; set; }
        //public float LoanBalance { get; set; }
        public Loan(string customernumber, float loanamount, DateTime dateissued)
        {
            CustomerNumber = customernumber;
            LoanAmount = loanamount;
            DateIssued = dateissued;

        }
    }
}
