using System;

namespace _06.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());
            double microbusCargo = 0;
            double truckCargo = 0;
            double trainCargo = 0;

            for (int i = 0; i < cargoCount; i++)
            {
                int cargoWeight = int.Parse(Console.ReadLine());
                if (cargoWeight <= 3)
                {
                    microbusCargo += cargoWeight;
                }
                else if (cargoWeight <= 11)
                {
                    truckCargo+= cargoWeight;
                }
                else 
                {
                    trainCargo+= cargoWeight;
                }
            }

            double sumOfAllCargos = trainCargo + truckCargo + microbusCargo;
            double microbusCargoPercentage = (microbusCargo/ sumOfAllCargos) * 100;
            double truckCargoPercentage = (truckCargo / sumOfAllCargos) * 100;
            double trainCargoPercentage = (trainCargo / sumOfAllCargos) * 100;
            double averagePrice = (microbusCargo * 200 + truckCargo * 175 + trainCargo * 120) / sumOfAllCargos;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{microbusCargoPercentage:f2}%");
            Console.WriteLine($"{truckCargoPercentage:f2}%");
            Console.WriteLine($"{trainCargoPercentage:f2}%");
        }
    }
}
