using System;
using System.Drawing;
using System.Globalization;
using System.Transactions;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int countOfAssessors = int.Parse(Console.ReadLine());
            double totalResult = academyPoints;
            for (int i = 0; i < countOfAssessors && totalResult < 1250.5; i++)
            {
                string assessorName = Console.ReadLine();
                double assessorsPoints = double.Parse(Console.ReadLine());
                double result = ((assessorName.Length * assessorsPoints) / 2);
                totalResult += result;
                if (totalResult > 1250.5)
                {
                     Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalResult:f1}!");
                }
                                  
            }
            if (1250.5 > totalResult)
            {
                double requiredPoints = 1250.5 - totalResult;
                Console.WriteLine($"Sorry, {actorName} you need {requiredPoints:f1} more!");
            }
            





        }
}
}
