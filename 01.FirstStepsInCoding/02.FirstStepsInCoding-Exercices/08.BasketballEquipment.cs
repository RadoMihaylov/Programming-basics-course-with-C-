using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualTax = int.Parse(Console.ReadLine());

            double sneakers = annualTax * 0.6;
            double equip = sneakers * 0.8;
            double ball = equip * 0.25;
            double accessoires = ball * 0.2;

            double expense = sneakers + equip + accessoires + ball + annualTax;
            Console.WriteLine(expense);

        }
    }
}
