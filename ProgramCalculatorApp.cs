using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple console calculator using basic arithmetic
            double num1 = 0; double num2 = 0;
            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Choose: a-Add, s-Subtract, m-Multiply, d-Divide");
            string op = Console.ReadLine();
            
            double result = 0;
            switch (op)
            {
                case "a": result = num1 + num2; break;
                case "s": result = num1 - num2; break;
                case "m": result = num1 * num2; break;
                case "d": result = num2 != 0 ? num1 / num2 : 0; break;
            }
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}
