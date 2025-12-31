using System;

namespace StudentCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            Console.WriteLine("--- My Simple Calculator ---");

            while (keepRunning)
            {
                // Input first number
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Input operator
                Console.Write("Enter operator (+, -, *, /): ");
                string op = Console.ReadLine();

                // Input second number
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                // Logic for calculation
                if (op == "+")
                {
                    result = num1 + num2;
                    Console.WriteLine("Result: " + num1 + " + " + num2 + " = " + result);
                }
                else if (op == "-")
                {
                    result = num1 - num2;
                    Console.WriteLine("Result: " + num1 + " - " + num2 + " = " + result);
                }
                else if (op == "*")
                {
                    result = num1 * num2;
                    Console.WriteLine("Result: " + num1 + " * " + num2 + " = " + result);
                }
                else if (op == "/")
                {
                    // Basic check for division by zero
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + num1 + " / " + num2 + " = " + result);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operator!");
                }

                // Ask to continue
                Console.WriteLine("----------------------------");
                Console.Write("Calculate again? (y/n): ");
                string choice = Console.ReadLine().ToLower();

                if (choice != "y")
                {
                    keepRunning = false;
                }
                
                Console.WriteLine(); // Just for spacing
            }

            Console.WriteLine("Goodbye!");
        }
    }
}