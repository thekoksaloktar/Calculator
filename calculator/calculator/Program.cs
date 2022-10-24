using System;
using System.Diagnostics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Enter1_number, Enter2_number ;

            double result;

            string process;

            Console.WriteLine("Enter a number:");
            Enter1_number = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second number:");
            Enter2_number = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("choose process(*,/,+,-)");
            process = Console.ReadLine();

            if (process == "*")
            {
                result = Enter1_number * Enter2_number;
                Console.WriteLine("Result: " + result);
            }
            if (process == "/")
            {
                result = Enter1_number / Enter2_number;
                Console.WriteLine("Result: " + result);
            }
            if (process == "+")
            {
                result = Enter1_number + Enter2_number;
                Console.WriteLine("Result: " + result);
            }
            if (process == "-")
            {
                result = Enter1_number - Enter2_number;
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
