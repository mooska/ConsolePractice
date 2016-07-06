using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter customer ID: ");
            var userInput = Console.ReadLine();
            Customer MyCustomer = CustomerRepository.Find(CustomerRepository.Retrieve(), int.Parse(userInput));
            CustomerRepository.WriteCustomer(MyCustomer);
            Console.ReadLine();
        }
    }
}
