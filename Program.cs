using System;

namespace Exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in two numbers");

            var first = 0d;
            var gettingFirstNumber = true;
            while (gettingFirstNumber)
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    var num1 = Console.ReadLine();
                    first = double.Parse(num1);
                    gettingFirstNumber = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("That was not a number, try again");
                }
            }

            Console.WriteLine("Enter Second Number");
            var num2 = Console.ReadLine();

            var second = double.Parse(num2);

            var quotient = first / second;

            Console.WriteLine($"the answer is {quotient}");



        }
    }
}
