using System;

namespace _03.CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degreeCelsius = double.Parse(Console.ReadLine());
            // * 1.8 + 32 
            double degreeFahrenheit = degreeCelsius * 1.8 + 32;
            Console.WriteLine($"{degreeFahrenheit:f2}");



        }
    }
}
