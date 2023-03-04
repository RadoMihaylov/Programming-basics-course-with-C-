using System;
using System.Drawing;
using System.Transactions;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
           
            if (figure == "square")
            {
                double lenghtA = double.Parse(Console.ReadLine());
                double area = lenghtA * lenghtA;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "rectangle")
            {
                double lenghtA = double.Parse(Console.ReadLine());
                double lenghtB = double.Parse(Console.ReadLine());
                double area = lenghtA * lenghtB;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.Pow(r, 2) * Math.PI;
                Console.WriteLine($"{area:f3}");

            }
            else if (figure == "triangle")
            {
                double lenghtA = double.Parse(Console.ReadLine());
                double heightB = double.Parse(Console.ReadLine());
                double area = (lenghtA * heightB) / 2;
                Console.WriteLine($"{area:f3}");

            }
        
        }
    }
}
