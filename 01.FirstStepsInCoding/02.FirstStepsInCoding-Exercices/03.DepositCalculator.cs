using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());
            int termOfDeposite = int.Parse(Console.ReadLine());
            double annualPercentage = double.Parse(Console.ReadLine());

            // сума = депозирана сума + срок на депозита *((депозирана сума * годишен лихвен процент ) / 12)
            double sum = depositedSum + termOfDeposite * ((depositedSum * annualPercentage * 0.01) / 12);
            Console.WriteLine(sum);
        }
    }
}
