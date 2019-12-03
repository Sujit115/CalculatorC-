using System;

namespace CalculatorCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the first number");
            float FirstNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Type the second number");
            float SecondNumber = Convert.ToInt16(Console.ReadLine()); ;
            Console.WriteLine("Type the operator");
            string Operator = Console.ReadLine();
            float Output = 0;

            if (Operator == "+")
            {
                Output = FirstNumber + SecondNumber;
            }
            else if (Operator == "*")

                //try
                //{
                //    Output = FirstNumber / SecondNumber ;
                //}
                //catch (Exception)
                //{

                //    while (SecondNumber == 0)
                //    {
                //        Console.WriteLine("The denominator should not be zero");
                //        SecondNumber = Convert.ToInt16(Console.ReadLine());

                //    }

                //}
                Console.WriteLine(Output);
            Console.WriteLine("Hello World!");
        }
    }
}
