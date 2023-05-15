using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());
            string action = "";
            double money = 0;
            int dayCount = 0;
            int consecutiveDays = 0;

            while (consecutiveDays < 5 || neededMoney > moneyOnHand)
            {
                if (moneyOnHand >= neededMoney || consecutiveDays >= 5) 
                {
                    break;
                }

                action = Console.ReadLine();    
                money = double.Parse(Console.ReadLine());
                dayCount++;
                switch (action)
                {
                    case "spend":
                        moneyOnHand -= money;
                        consecutiveDays++;
                        if (moneyOnHand <= 0)
                        {
                            moneyOnHand = 0;
                        }
                        break;
                    case "save":
                        moneyOnHand += money;
                        consecutiveDays = 0;                        
                        break;
                }

            }

            if (moneyOnHand >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {dayCount} days.");
            }
            if (consecutiveDays >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{dayCount}");

            }


        }
    }
}
