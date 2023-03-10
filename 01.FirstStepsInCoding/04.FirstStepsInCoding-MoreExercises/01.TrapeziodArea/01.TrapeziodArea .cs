using System;
using System.Diagnostics;

namespace _01.TrapeziodArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideB1 = double.Parse(Console.ReadLine());
            double sideB2 = double.Parse(Console.ReadLine());
            double heightH = double.Parse(Console.ReadLine());

            double trapezArea = (sideB1 + sideB2) * heightH / 2;
            Console.WriteLine($"{trapezArea:f2}");


        }
    }
}
