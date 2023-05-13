using System;
using System.Reflection.Metadata.Ecma335;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Read inputs
            // - at the first row: name of the student
            // - and the others rows: annual notes

            // 2.Student move on next class with note >= 4
            // - if student is reject and he gets kick off and the programme break
            // - print name of the student and the classe
            string name = Console.ReadLine();
            int grade = 1;
            int badGrades = 0;            
            double sumOfGrades = 0;

            while (grade <= 12)
            {
                double grades = double.Parse(Console.ReadLine());
                if (grades < 4)
                {
                    badGrades++;
                    if (badGrades == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }
                    continue;
                }
                
                grade++;
                sumOfGrades += grades;
            }
            double averageGrades = sumOfGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrades:f2}");


        }
    }
}
