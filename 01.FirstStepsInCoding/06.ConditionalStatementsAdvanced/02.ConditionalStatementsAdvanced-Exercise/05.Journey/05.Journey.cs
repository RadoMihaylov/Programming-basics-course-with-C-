using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Inputs
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string kindOfVacation = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    budget = budget * 0.3;
                }
                else if (season == "winter")
                {
                    budget = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    budget = budget * 0.4;
                }
                else if (season == "winter")
                {
                    budget = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                if (season == "summer" || season == "winter")
                {
                    budget = budget * 0.9;
                }
            }
            //    C) Summer = Camp
            //    D) Winter = Hotel / Europe = Hotel

            if (season == "summer")
            {
                kindOfVacation = "Camp";
            }
            else if (season == "winter")
            {
                kindOfVacation = "Hotel";
            }

            if (destination == "Europe")
            {
                kindOfVacation = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{kindOfVacation} - {budget:f2}");
        }
    }
}
