using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stem_Assignment
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerNumber { get; set; }
        public DateTime Date { get; set; }

        public Customer(string firstname, string lastname, string customernumber, DateTime date)
        {
            FirstName = firstname;
            LastName = lastname;
            CustomerNumber = customernumber;
            Date = date;

        }
    }
}
