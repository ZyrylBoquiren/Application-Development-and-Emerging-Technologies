using System;

namespace StudentCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            // Adding a little flair to the header for the new branch
            Console.WriteLine("--- Student Scientific Calculator (v2.0) ---");

            while (keepRunning)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Basic (+, -, *, /)");
                Console.WriteLine("2. Square Root (sqrt)");
                Console.WriteLine("3. Power (^) ");
                Console.Write("Your choice: ");
                string mode = Console.ReadLine();

                if (mode == "1")
                {
                    // Regular Calculator Logic
                    Console.Write("Enter first number: ");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter operator (+, -, *, /): ");
                    string op = Console.ReadLine();
                    Console.Write("Enter second number: ");
                    double n2 = Convert.ToDouble(Console.ReadLine());

                    if (op == "+") Console.WriteLine("Result: " + (n1 + n2));
                    else if (op == "-") Console.WriteLine("Result: " + (n1 - n2));
                    else if (op == "*") Console.WriteLine("Result: " + (n1 * n2));
                    else if (op == "/") Console.WriteLine("Result: " + (n1 / n2));
                }
                else if (mode == "2")
                {
                    // Scientific: Square Root
                    Console.Write("Enter number to sqrt: ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    // Using Math.Sqrt is the standard way students learn this
                    Console.WriteLine("Result: √" + num + " = " + Math.Sqrt(num));
                }
                else if (mode == "3")
                {
                    // Scientific: Power
                    Console.Write("Enter base number: ");
                    double baseNum = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter exponent: ");
                    double expo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Result: " + baseNum + " to the power of " + expo + " = " + Math.Pow(baseNum, expo));
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                }

                Console.Write("\nContinue? (y/n): ");
                if (Console.ReadLine().ToLower() != "y") keepRunning = false;
            }
            Console.WriteLine("Goodbye!");
        }
    }
}