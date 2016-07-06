using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int CustomerDebit { get; set; }
        public int CustomerCredit { get; set; }
        public string CustomerCity { get; set; }
        public bool CustomerMale { get; set; }

        public Customer(int customerID, string customerFirstName, string customerLastName, int customerDebit, int customerCredit, string customerCity, bool customerMale)
        {
            CustomerID = customerID;
            CustomerFirstName = customerFirstName;
            CustomerLastName = customerLastName;
            CustomerDebit = customerDebit;
            CustomerCredit = customerCredit;
            CustomerCity = customerCity;
            CustomerMale = customerMale;
        }
    }
}
