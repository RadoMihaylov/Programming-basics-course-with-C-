using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());  
            int height = int.Parse(Console.ReadLine());
            double pourcentage = double.Parse(Console.ReadLine()) / 100;

            double volume = (lenght * width * height) * 0.001;
            double finalVolume = volume - (volume * pourcentage);

            Console.WriteLine(finalVolume);
            
        }
    }
}
