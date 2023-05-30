using System;

namespace _4.TrainТheТrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string movieName = Console.ReadLine();
            int student = 0;
            int standard = 0;
            double occupiedSeats = 0;
            int kid = 0;
            int totalCountOfTickets = 0;

            while (movieName != "Finish")
            {
                occupiedSeats = 0; /*student = 0; standard = 0; kid = 0;*/ 
                int freeSeats = int.Parse(Console.ReadLine());
                for (int i = 0; i < freeSeats; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                   
                    if (ticketType == "student")
                    {
                        student++;
                        totalCountOfTickets++;
                    }
                    if (ticketType == "standard")
                    {
                        standard++;
                        totalCountOfTickets++;
                    }
                    if (ticketType == "kid")
                    {
                        kid++;
                        totalCountOfTickets++;
                    }
                    occupiedSeats++;
                }
               
                double percentageOfOccupiedSeats = (occupiedSeats / freeSeats) * 100;
                
                Console.WriteLine($"{movieName} - {percentageOfOccupiedSeats:f2}% full.");
                percentageOfOccupiedSeats = 0;
                movieName = Console.ReadLine();

            }

            if (movieName == "Finish")
            {
                Console.WriteLine($"Total tickets: {totalCountOfTickets}");
                Console.WriteLine($"{(student / (double)totalCountOfTickets) * 100:f2}% student tickets.");
                Console.WriteLine($"{(standard / (double)totalCountOfTickets) * 100:f2}% standard tickets.");
                Console.WriteLine($"{(kid / (double)totalCountOfTickets) * 100:f2}% kids tickets.");
            }

        }
    }
}
