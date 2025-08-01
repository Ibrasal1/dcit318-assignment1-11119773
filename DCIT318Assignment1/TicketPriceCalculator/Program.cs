using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TICKET PRICE CALCULATOR");

            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            int age;

            if (int.TryParse(input, out age) && age > 0)
            {
                decimal price;

                if (age <= 12 || age >= 65)
                    price = 7.00m;
                else
                    price = 10.00m;

                Console.WriteLine($"Your ticket price is: GHC{price}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid age.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
