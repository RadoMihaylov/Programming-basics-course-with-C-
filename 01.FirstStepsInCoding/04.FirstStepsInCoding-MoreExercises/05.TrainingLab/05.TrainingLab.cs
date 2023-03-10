using System;

namespace _05.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат 2 числа, по едно на ред: w(дължина в метри) и h(широчина в метри).
            //Ограничения: 3 ≤ h ≤ w ≤ 100.

            double lenhgtW = double.Parse(Console.ReadLine());
            double heightH = double.Parse(Console.ReadLine());
            Console.WriteLine(heightH * lenhgtW);


        }
    }
}
