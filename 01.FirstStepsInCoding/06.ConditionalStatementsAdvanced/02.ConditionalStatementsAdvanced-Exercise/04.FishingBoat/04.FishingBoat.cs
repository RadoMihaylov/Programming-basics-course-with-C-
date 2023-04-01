using System;
using System.Diagnostics;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;

            }

            if (fishermanCount <= 6)
            {
                price = price * 0.9;
            }
            else if (fishermanCount <= 11)
            {
                price = price * 0.85;
            }
            else if (fishermanCount >= 12)
            {
                price = price * 0.75;
            }
            
            
            if (fishermanCount % 2 == 0 && season != "Autumn") 
            {
                price = price * 0.95;
            }

            if (budget >= price)
            {
                double remainingMoney = budget - price;
                Console.WriteLine($"Yes! You have {remainingMoney:f2} leva left.");
            }
            else
            {
                double requiredMoney = price - budget;
                Console.WriteLine($"Not enough money! You need {requiredMoney:f2} leva.");
            }
        }
    }
}
