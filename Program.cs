using ShaMathConsole.Classes;
using System;

namespace ShaMathConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            try
            {
                Console.WriteLine("Please enter your first number:");
                number1 = Convert.ToInt32((Console.ReadLine().ToString()));

                Console.WriteLine("Please enter your second number:");
                number2 = Convert.ToInt32((Console.ReadLine().ToString()));


                Math1 math1 = new Math1();
                Console.WriteLine(math1.Add(number1, number2));
                Console.WriteLine(math1.Substract(number1, number2));
                Console.WriteLine(math1.Multiply(number1, number2));

                Math2 math2 = new Math2();
                Console.WriteLine(math2.Add(number1, number2));
                Console.WriteLine(math2.Substract(number1, number2));
                Console.WriteLine(math2.Multiply(number1, number2));

                Math3 math3 = new Math3();
                Console.WriteLine(math3.Add(number1, number2));
                Console.WriteLine(math3.Substract(number1, number2));
                Console.WriteLine(math3.Multiply(number1, number2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
