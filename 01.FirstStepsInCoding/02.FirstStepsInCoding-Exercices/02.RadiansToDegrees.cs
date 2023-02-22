using System;

namespace _02.RadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angleInRadians = double.Parse(Console.ReadLine());
            double a = Math.PI;
            double degree = angleInRadians * 180 / a;
            Console.WriteLine(degree);
        }
    }
}
