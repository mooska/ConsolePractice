using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    public class CustomerRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerList"></param>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static Customer Find(List<Customer> customerList, int customerID)
        {
            Customer matchedCustomer = null;
            //var query = from c in customerList
            //            where c.CustomerID == customerID
            //            select c;
            ////matchedCustomer = query.First();

            matchedCustomer = customerList.FirstOrDefault(c => c.CustomerID == customerID);

            //matchedCustomer = customerList.Where(c =>
            //    c.CustomerID == customerID)
            //    .Skip(1)
            //    .FirstOrDefault();

            return matchedCustomer;
        }

        public static void WriteCustomer(Customer customer)
        {
            Console.WriteLine($"Customer name: {customer.CustomerFirstName} {customer.CustomerLastName}" );
            Console.WriteLine($"Customer credit: {customer.CustomerCredit}");
            Console.WriteLine($"Customer debit: {customer.CustomerCredit}");
            Console.WriteLine($"Customer location: {customer.CustomerCity}");
            var gender = customer.CustomerMale ? "Male" : "Female";
            Console.WriteLine($"Gender: {gender}");
        }

        public static List<Customer> Retrieve() { 
            List<Customer> customerList = new List<Customer>
            {
                new Customer(001, "Ryan", "Atkins", 0, 1000, "Columbus", true),
                new Customer(002, "Ryan", "Reynolds", 1000, 0, "Los Angeles", true),
                new Customer(003, "Meg", "Ryan", 50, 2000, "Los Angeles", false),
                new Customer(004, "Federico", "Higuain", 1000, 0, "Los Angeles", true),
                new Customer(005, "Maria", "Fisher", 0, 0, "Patriot", false),
                new Customer(006, "Gonzalo", "Higuain", 500, 750, "Napoli", true),
                new Customer(007, "Shyan", "Youngblood", 1500, 1750, "Columbus", false)
            };
            return customerList;
        }
    }
}
