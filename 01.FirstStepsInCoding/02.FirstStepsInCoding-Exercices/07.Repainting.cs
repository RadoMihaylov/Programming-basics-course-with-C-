using System;

namespace _07.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            double sum = (nylon + 2) * 1.5 + (paint + paint * 0.1) * 14.5 + (diluent * 5.0) + 0.4;
            double workersSum = workHours * (sum * 0.3);
            double finalPrice = workersSum + sum;
            Console.WriteLine(finalPrice);
        }
    }
}
