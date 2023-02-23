using System;
using System.Diagnostics.CodeAnalysis;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int litersOfDetergent = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double sum = pens * 5.8 + markers * 7.2 + litersOfDetergent * 1.2;
            double finalPrice = sum - (sum * discount * 0.01);
            Console.WriteLine(finalPrice);

        }
    }
}
