using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Град    0 ≤ s ≤ 500  500 < s ≤ 1 000  1 000 < s ≤ 10 000   s > 10 000
            //Sofia       5 %           7 %                8 %              12 %
            //Varna       4.5 %         7.5 %              10 %             13 %
            //Plovdiv     5.5 %         8 %                12 %             14.5 %

            string city = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());
            double commission = 0;

            if (salesVolume <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = salesVolume * (5.0 / 100);
                        break;
                    case "Varna":
                        commission = salesVolume * (4.5 / 100);
                        break;
                    case "Plovdiv":
                        commission = salesVolume * (5.5 / 100);
                        break;
                    default:
                        {
                            if (city != "Sofia" || city != "Varna" || city != "Plovdiv")
                            {
                                Console.WriteLine("error");
                            }
                        }
                        break;
                }
            }
            else if (salesVolume <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = salesVolume * (7.0 / 100);
                        break;
                    case "Varna":
                        commission = salesVolume * (7.5 / 100);
                        break;
                    case "Plovdiv":
                        commission = salesVolume * (8.0 / 100);
                        break;
                    default:
                        {
                            if (city != "Sofia" || city != "Varna" || city != "Plovdiv")
                            {
                                Console.WriteLine("error");
                            }
                        }
                        break;
                }
            }
            else if (salesVolume <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = salesVolume * (8.0 / 100);
                        break;
                    case "Varna":
                        commission = salesVolume * (10.0 / 100);
                        break;
                    case "Plovdiv":
                        commission = salesVolume * (12.0 / 100);
                        break;
                    default:
                        {
                            if (city != "Sofia" || city != "Varna" || city != "Plovdiv")
                            {
                                Console.WriteLine("error");
                            }
                        }
                        break;
                }
            }
            else if (salesVolume > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = salesVolume * (12.0 / 100);
                        break;
                    case "Varna":
                        commission = salesVolume * (13.0 / 100);
                        break;
                    case "Plovdiv":
                        commission = salesVolume * (14.5 / 100);
                        break;
                    default:
                        {
                            if (city != "Sofia" || city != "Varna" || city != "Plovdiv")
                            {
                                Console.WriteLine("error");
                            }
                        }
                        break;
                }
            }          
            
            if (salesVolume < 0)
            {
                Console.WriteLine("error");
            }
           
            
            if (commission > 0)
            {
              Console.WriteLine($"{commission:f2}");
            }
            
        }
    }
}
