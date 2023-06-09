using System;

namespace _02.SmartLilly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toysCount = 0;
            int money = 10;
            int moneyAmount = 0;


            for (int i = 1; i <= age; i++)
            {
                
                if (i % 2 == 0)
                {
                    moneyAmount += money - 1;
                    money += 10;
                }
                else
                {
                    toysCount++;
                }
               
            }
            moneyAmount = moneyAmount + toysCount * toyPrice;
            
            
            if (moneyAmount >= washingMachinePrice)
            {
                double remainingMoney = Math.Abs(washingMachinePrice - moneyAmount); 
                Console.WriteLine($"Yes! {remainingMoney:f2}");
            }
            else
            {
                double requiredMoney = Math.Abs(washingMachinePrice - moneyAmount);
                Console.WriteLine($"No! {requiredMoney:f2}");               
            }
        }
    }
}
