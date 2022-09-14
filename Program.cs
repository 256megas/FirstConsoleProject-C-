using System;

namespace FirstConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01;
            double num02;
            Console.Write("Type a number to be divided: ");
            num01 = Convert.ToDouble( Console.ReadLine());
            Console.Write("Type another number: ");
            num02 = Convert.ToDouble(Console.ReadLine());
            Console.Write("The result is: " + num01/num02);
            Console.ReadKey();
        }
    }
}
