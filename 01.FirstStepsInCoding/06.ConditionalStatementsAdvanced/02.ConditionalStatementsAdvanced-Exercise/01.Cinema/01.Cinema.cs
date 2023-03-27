using System;
using System.Data;
using System.Threading;

namespace _07.ConditionalStatementsAdvanced_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            double ticket = 0;
            switch (projection)
            {
                case "Premiere":
                    ticket = 12;
                    break;
                case "Normal":
                    ticket = 7.50;
                    break;
                case "Discount":
                    ticket = 5;
                    break;               
            }
            double ticketPrice = row * ticket * column;
            Console.WriteLine($"{ticketPrice:f2} leva");
        } 
        
    }
}
