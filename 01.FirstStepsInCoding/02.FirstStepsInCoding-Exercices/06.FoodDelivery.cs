using System;
using System.Diagnostics.CodeAnalysis;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countChickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double sum = countChickenMenu * 10.35 + fishMenu * 12.4 + vegetarianMenu * 8.15;
            double finalPrice = sum + (sum * 0.2) + 2.5;
            Console.WriteLine(finalPrice);

        }
    }
}
