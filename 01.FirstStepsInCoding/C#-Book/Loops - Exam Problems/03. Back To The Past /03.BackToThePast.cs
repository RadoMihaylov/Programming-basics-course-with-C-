using System;

namespace _03.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int livingAge = int.Parse(Console.ReadLine());            
            double moneySpent = 0;
            double amountOfSpentMoney = 0;
            int ageOfIvan = 18;

            for (int i = 1800; i <= livingAge; i++)
            {
                if (i % 2 == 0)
                {
                    moneySpent = 12000;
                    amountOfSpentMoney += moneySpent;
                }
                else
                {
                    moneySpent = 12000 + ageOfIvan * 50;
                    amountOfSpentMoney += moneySpent;
                }
                ageOfIvan++;
            }
            inheritedMoney -= amountOfSpentMoney;
            if (inheritedMoney >= 0 )
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left.");
            }
            else
            {
                Math.Abs(inheritedMoney - amountOfSpentMoney);
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }
        }
    }
}
