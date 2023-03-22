using System;

namespace _08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Monday  Tuesday  Wednesday  Thursday    Friday  Saturday    Sunday
             // 12       12        14        14          12      16         16

            string day = Console.ReadLine();

            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                Console.WriteLine(12);
            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                Console.WriteLine(14);
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine(16);
            }
        }
    }
}
