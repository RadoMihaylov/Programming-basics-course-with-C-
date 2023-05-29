using System;
using System.Transactions;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  countOfJudges = int.Parse(Console.ReadLine());
            string projectName = Console.ReadLine();
            double grade = 0;
            int totalCountOfJudges = 0;
            double totalSumOfGrades = 0;
            double projectGrade = 0;

            while (projectName != "Finish")
            {               
                for (int i = 0; i < countOfJudges; i++)
                {
                    grade = double.Parse(Console.ReadLine());                    
                    totalCountOfJudges++;
                    totalSumOfGrades += grade;
                    projectGrade += grade;
                }
                double averageProjectGrade = projectGrade / countOfJudges;
                Console.WriteLine($"{projectName} - {averageProjectGrade:f2}.");

                projectGrade = 0;
                double totalAverageSumOfGrade = totalSumOfGrades / totalCountOfJudges;
                projectName = Console.ReadLine();
                if (projectName == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {totalAverageSumOfGrade:f2}.");
                }
            }

              
        }
    }
}
