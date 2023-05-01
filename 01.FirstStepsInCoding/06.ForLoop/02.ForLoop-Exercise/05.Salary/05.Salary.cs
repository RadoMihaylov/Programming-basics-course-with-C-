using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < nTabs; i++)
            {
                string currentTab = Console.ReadLine();
                if (currentTab == "Facebook")
                {
                    salary -= 150;
                }
                else if (currentTab == "Instagram")
                {
                    salary -= 100;
                }
                else if (currentTab == "Reddit")
                {
                    salary -= 50;
                }
            }
            
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}
