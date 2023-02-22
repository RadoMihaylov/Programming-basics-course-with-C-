using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int pagesCount = int.Parse(Console.ReadLine());
           int pagesPerHour = int.Parse(Console.ReadLine());  
           int numberOfDays = int.Parse(Console.ReadLine());

            int hoursForReading = (pagesCount / pagesPerHour) / numberOfDays;
            Console.WriteLine(hoursForReading);
            
        }
    }
}
