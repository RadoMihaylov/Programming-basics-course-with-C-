using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double landscapedMeters = double.Parse(Console.ReadLine());
            double priceForMeter = 7.61;


            double price = (landscapedMeters * priceForMeter);
            double discount = price * 0.18;
            double finalPrice = price - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");




        }
            
    }
}
