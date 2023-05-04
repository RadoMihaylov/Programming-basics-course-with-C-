using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTornaments = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            int tournamentsPoints = 0;
            int points = 0;
            double wonTournaments = 0;

            for (int i = 0; i < countOfTornaments; i++)
            {
                string phase = Console.ReadLine();
                if (phase == "W")
                {
                    tournamentsPoints += 2000;
                    wonTournaments++;
                }
                else if (phase == "F")
                {
                    tournamentsPoints += 1200;
                }
                else if (phase == "SF")
                {
                    tournamentsPoints += 720;
                }

                points = initialPoints + tournamentsPoints;
                
            }
            int averagePoints = (points - initialPoints) / countOfTornaments;
            

            double percentWonTournaments = (wonTournaments / countOfTornaments) * 100;

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentWonTournaments:f2}%"); 

        }
    }
}
