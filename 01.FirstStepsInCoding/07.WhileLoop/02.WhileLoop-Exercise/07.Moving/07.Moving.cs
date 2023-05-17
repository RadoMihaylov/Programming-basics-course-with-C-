using System;

namespace _07.Moving
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int widht = int.Parse(Console.ReadLine());
			int lenght = int.Parse(Console.ReadLine());
			int height = int.Parse(Console.ReadLine());
			int freePlace = widht * lenght * height;
			int cubicMeters = 0;
			bool isStoped = false;

			while (freePlace > cubicMeters)
			{
				string command = Console.ReadLine();
				if (command == "Done")
				{
					isStoped= true;
					break;
				}
				int carriedCartons = int.Parse(command);
				cubicMeters += carriedCartons;
			   
			}
			int missingMeters = Math.Abs(freePlace - cubicMeters);
			if (isStoped)
			{
                Console.WriteLine($"{missingMeters} Cubic meters left.");
    //            if (freePlace> cubicMeters)
				//{
				//	int remainingSpace = freePlace - cubicMeters;
				//	Console.WriteLine($"{remainingSpace} Cubic meters left.");

    //            }			
            }
			else
			{
				Console.WriteLine($"No more free space! You need {missingMeters} Cubic meters more.");
			}
		}
	}
}
