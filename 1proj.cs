using System;
class Program
{
    static void Main()
    {
        double memory = 0;
        double a = 0;
        int b = 0;
        string z = "";
        while (true)
        {
            Console.Write("First num: ");
            string inputA = Console.ReadLine();
            if (double.TryParse(inputA, out a))
            {
                break;
            }
            else
            {
                Console.WriteLine("NumberValue Error.Try again");
            }
        }
        Console.Write("what do u wanna do (+, -, *, /, 1/a, **, sqrt, M+, M-, MR): ");
        z = Console.ReadLine();

        if (z == "+" || z == "-" || z == "*" || z == "/" || z == "**")
        {
            while (true)
            {
                Console.Write("second num b: ");
                string inputB = Console.ReadLine();
                if (int.TryParse(inputB, out b))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("enter an integer");
                }
            }
        }
        switch (z)
        {
            case "+":
                Console.WriteLine(a + b);
                break;
            case "-":
                Console.WriteLine(a - b);
                break;
            case "*":
                Console.WriteLine(a * b);
                break;
            case "/":
                if (b != 0)
                {
                    Console.WriteLine((double)a / b);
                }
                else
                {
                    Console.WriteLine("ZeroDivisionError");
                }
                break;
            case "1/a":
                if (a != 0)
                {
                    Console.WriteLine(1 / a);
                }
                else
                {
                    Console.WriteLine("ZeroDivisionError");
                }
                break;
            case "**":
                Console.WriteLine(Math.Pow(a, b));
                break;
            case "sqrt":
                if (a >= 0)
                {
                    Console.WriteLine(Math.Sqrt(a));
                }
                else
                {
                    Console.WriteLine("Error. sqrt of the negative");
                }
                break;
            case "M+":
                memory += a;
                Console.WriteLine("Memory: " + memory);
                break;
            case "M-":
                memory -= a;
                Console.WriteLine("Memory: " + memory);
                break;
            case "MR":
                Console.WriteLine("From memory " + memory);
                break;
            default:
                Console.WriteLine("Unknown operator");
                break;
        }
    }
}