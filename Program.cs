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
            // Value equality module
            Food cookie = new Food("Lemon cookie", FoodGroup.Dessert);
            Food cookie2 = new Food("Lemon cookie", FoodGroup.Dessert);
            Food lemon = new Food("Lemon", FoodGroup.Fruit);

            IsFoodEqual(lemon, cookie);
            IsFoodEqual(cookie, cookie2);


            // Reference equality module
            Drink coke = new Drink("Coke", DrinkGroup.Soda);
            Drink coke2 = new Drink("Coke", DrinkGroup.Soda);
            Drink pepsi = new Drink("Pepsi", DrinkGroup.Soda);

            IsDrinkEqual(coke, pepsi);
            IsDrinkEqual(coke, coke2);
           

            // Linq practice
            Console.Write("Please enter customer ID: ");
            var userInput = Console.ReadLine();
            Customer MyCustomer = CustomerRepository.Find(CustomerRepository.Retrieve(), int.Parse(userInput));
            CustomerRepository.WriteCustomer(MyCustomer);
            Console.ReadLine();
        }

        static void IsFoodEqual(Food obj1, Food obj2)
        {
            if(obj1 == obj2)
                Console.WriteLine(string.Format("{0} == {1}", obj1, obj2));
            else
                Console.WriteLine(string.Format("{0} != {1}", obj1, obj2));
        }

        static void IsDrinkEqual(Drink obj1, Drink obj2)
        {
            if (obj1 == obj2)
                Console.WriteLine(string.Format("{0} == {1}", obj1, obj2));
            else
                Console.WriteLine(string.Format("{0} != {1}", obj1, obj2));
        }
    }
}