using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int unsatisfactoryGrade = int.Parse(Console.ReadLine());
            double grade = 0;
            string exerciceName = "";
            double badGrades = 0;
            bool isFailed = false;
            int countOfGrades = 0;
            double sumOfGrades = 0;
            string lastExerciceName = "";

            while (unsatisfactoryGrade > badGrades)
            {
                exerciceName= Console.ReadLine();
                if (exerciceName == "Enough")
                {
                    Console.WriteLine();
                    isFailed = true;
                    break;
                }
                grade = double.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGrades++;
                }
                countOfGrades++;
                sumOfGrades += grade;
                lastExerciceName = exerciceName;
            }
            double averageGrade = sumOfGrades / countOfGrades;
            if (isFailed)
            {
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {countOfGrades}");
                Console.WriteLine($"Last problem: {lastExerciceName}");
            }
            if (isFailed == false)
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades.");
            }
        }
    }
}
