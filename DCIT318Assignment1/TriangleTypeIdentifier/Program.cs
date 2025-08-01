using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRIANGLE TYPE IDENTIFIER");

            Console.Write("Enter side 1: ");
            double side1 = GetValidSide();

            Console.Write("Enter side 2: ");
            double side2 = GetValidSide();

            Console.Write("Enter side 3: ");
            double side3 = GetValidSide();

            if (IsTriangleValid(side1, side2, side3))
            {
                if (side1 == side2 && side2 == side3)
                    Console.WriteLine("Triangle Type: Equilateral");
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                    Console.WriteLine("Triangle Type: Isosceles");
                else
                    Console.WriteLine("Triangle Type: Scalene");
            }
            else
            {
                Console.WriteLine("The sides entered do not form a valid triangle.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static double GetValidSide()
        {
            double side;
            while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
            {
                Console.Write("Invalid input. Enter a positive number: ");
            }
            return side;
        }

        static bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
