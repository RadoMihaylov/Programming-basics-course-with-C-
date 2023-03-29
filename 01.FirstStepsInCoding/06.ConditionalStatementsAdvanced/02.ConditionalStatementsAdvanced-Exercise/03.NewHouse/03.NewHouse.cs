using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //   цвете            Роза    Далия     Лале    Нарцис      Гладиола
          //Цена на брой в лева  5        3.80    2.80      3           2.50

            string flowers = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget =  int.Parse(Console.ReadLine());
            double price = 0;
            
            double finalPrice = price * flowersCount;
            switch (flowers)
            {
                case "Roses":
                    price = 5;
                    finalPrice= price * flowersCount;
                    if (flowersCount > 80)
                    {
                       finalPrice = (flowersCount * price) * 0.9;
                    }
                    break;
                case "Dahlias":
                    price = 3.8;
                    finalPrice = flowersCount * price;
                    if (flowersCount > 90)
                    {
                        finalPrice = (flowersCount * price) * 0.85;
                    }
                    break;
                case "Tulips":
                    price = 2.8;
                    finalPrice = price * flowersCount;
                    if (flowersCount > 80)
                    {
                        finalPrice = (flowersCount * price) * 0.85;
                    }
                    break;
                case "Narcissus":
                    price = 3;
                    finalPrice = flowersCount * price;
                    if (flowersCount < 120)
                    {
                        finalPrice = (flowersCount * price) * 1.15;
                    }
                    break;
                case "Gladiolus":
                    price = 2.5;
                    finalPrice = flowersCount * price;
                    if (flowersCount < 80)
                    {
                        finalPrice = (flowersCount * price) * 1.2;
                    }
                    break;
                    
            }

           
            if (budget >= finalPrice)
            {
                double remainingMoney = budget - finalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {remainingMoney:f2} leva left.");
            }
            else
            {
                double requiredMoney = finalPrice - budget;
                Console.WriteLine($"Not enough money, you need {requiredMoney:f2} leva more.");
            }
            

        }
    }
}
