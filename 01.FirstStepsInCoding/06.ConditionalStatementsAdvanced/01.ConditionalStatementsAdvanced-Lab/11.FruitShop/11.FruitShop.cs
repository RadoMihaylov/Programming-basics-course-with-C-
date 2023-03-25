using Microsoft.VisualBasic;
using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //     Магазин за плодове през работните дни работи на следните цени:
         // плод    banana  apple   orange  grapefruit   kiwi    pineapple   grapes
         // цена    2.50    1.20    0.85     1.45         2.70    5.50       3.85

         //  Събота и неделя магазинът работи на по - високи цени:
         //плод    banana  apple   orange  grapefruit   kiwi    pineapple  grapes
         //цена    2.70    1.25    0.90      1.60       3.00      5.60       4.20

             string fruit = Console.ReadLine();
             string day = Console.ReadLine();
             double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruit == "banana")
                    {
                        price = 2.5;
                    }
                    else if (fruit == "apple")
                    {
                        price = 1.2;
                    }
                    else if (fruit == "orange")
                    {
                        price = 0.85;
                    }
                    else if (fruit == "grapefruit")
                    {
                        price = 1.45;
                    }
                    else if (fruit == "kiwi")
                    {
                        price = 2.7;
                    }
                    else if (fruit == "pineapple")
                    {
                        price = 5.5;
                    }
                    else if (fruit == "grapes")
                    {
                        price = 3.85;
                    }
                    else if (fruit != "banana" || fruit != "apple" || fruit != "orange" || fruit != "grapefruit" || fruit != "kiwi" || fruit != "pineapple" || fruit != "grapes") 
                    {
                        Console.WriteLine("error");
                    }                 
                    break;
                case "Saturday":
                case "Sunday":
                    if (fruit == "banana")
                    {
                        price = 2.7;
                    }
                    else if (fruit == "apple")
                    {
                        price = 1.25;
                    }
                    else if (fruit == "orange")
                    {
                        price = 0.9;
                    }
                    else if (fruit == "grapefruit")
                    {
                        price = 1.6;
                    }
                    else if (fruit == "kiwi")
                    {
                        price = 3;
                    }
                    else if (fruit == "pineapple")
                    {
                        price = 5.6;
                    }
                    else if (fruit == "grapes")
                    {
                        price = 4.2;
                    }                   
                    else if (fruit != "banana" || fruit != "apple" || fruit != "orange" || fruit != "grapefruit" || fruit != "kiwi" || fruit != "pineapple" || fruit != "grapes")
                    {
                        Console.WriteLine("error");
                    }                   
                    break;
                    default:
                    {
                        Console.WriteLine("error");
                    }
                    break;

            }
            if (price > 0)
            {
                double finalPrice = price * quantity;
                Console.WriteLine($"{finalPrice:f2}");
            }
            




        }
    }
}
