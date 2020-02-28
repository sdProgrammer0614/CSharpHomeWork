using System;

namespace Calculate01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number: ");
                double num1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                double num2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter an operator(+, -, *, /): ");
                string op = Console.ReadLine();
                double result = 0;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("DivideByZeroError");
                            return;
                        }
                        else
                        {
                            result = num1 / num2;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }

                Console.WriteLine($"{num1} {op} {num2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format error");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow error");
            }
            return;
        }
    }
}
