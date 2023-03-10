using System;

namespace _04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceKgVegetables = double.Parse(Console.ReadLine());
            double priceKgFruits = double.Parse(Console.ReadLine());
            int totalKgVegetables = int.Parse(Console.ReadLine());
            int totalKgFruits = int.Parse(Console.ReadLine());


            double totalSum = (priceKgFruits * totalKgFruits) + (priceKgVegetables * totalKgVegetables);
             double Sum = totalSum / 1.94;

                
            Console.WriteLine($"{Sum:f2}");
         }
    }
}
