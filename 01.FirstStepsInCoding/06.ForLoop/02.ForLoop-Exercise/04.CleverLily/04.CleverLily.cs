using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine()); 
            int toyPrice = int.Parse(Console.ReadLine());
            int savedMoney = 0;
            int giftedMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                
                if (i % 2 == 0)
                {                    
                    giftedMoney += 10;
                    savedMoney += giftedMoney - 1;
                }
                else if (i % 2 != 0) 
                {
                    
                    savedMoney += toyPrice;
                }
            }
            	
            double diff = Math.Abs(price - savedMoney);
            if (savedMoney >= price)
            {               
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {              
                Console.WriteLine($"No! {diff:f2}");
            }
          
        }
    }
}
