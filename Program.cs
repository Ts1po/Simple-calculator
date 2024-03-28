using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator
{
    internal class Program
    {
#pragma warning disable S2190
        static void Main(string[] args)
#pragma warning restore S2190
        {
            bool exit = false;

            while (!exit)
            {
                Console.Write("Please enter first number ");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please choose which manipulation you want (+, -, *, /): ");
                char option = Convert.ToChar(Console.ReadLine());

                Console.Write("Please enter second number ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch(option)
                {
                    case '+':
#pragma warning disable S1854
                        result = number1 + number2;
#pragma warning restore S1854
                        break;
                    case '-':
#pragma warning disable S1854
                        result = number1 - number2;
#pragma warning restore S1854
                        break;
                    case '*':
#pragma warning disable S1854
                        result = number1 * number2;
#pragma warning restore S1854
                        break;
                    case '/':
                        if (number2 != 0)
#pragma warning disable S1854
                            result = number1 / number2;
#pragma warning restore S1854
                        else
                            Console.WriteLine("Division by zero");
                        break;
                    default:
                        Console.WriteLine("Please choose correct manipulation");
                        break;
                }

                Console.WriteLine("Result = " + result);

                Console.WriteLine("Do you want more manipulation: ");
                char choice = Convert.ToChar(Console.ReadLine());

                if (choice != 'Y' && choice != 'y')
                {
                    exit = true;
                }
            }
        }
    }
}