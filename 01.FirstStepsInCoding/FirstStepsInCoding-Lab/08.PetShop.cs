using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDogFood = int.Parse(Console.ReadLine());
            int countCatFood = int.Parse(Console.ReadLine());

            double priceDogFood = 2.5;
            int priceCatFood = 4;

            double finalPrice = (countCatFood * priceCatFood) + (countDogFood * priceDogFood);
            Console.WriteLine(finalPrice);
        }
    }
}
