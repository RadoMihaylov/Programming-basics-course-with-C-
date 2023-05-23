using System;
using System.Threading;

namespace _06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int col = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            int appartementNumber = 0;
            int floorNumber = col;


            for (int i = col - 1; i >= 0; i--)
            {
                //if (i == col - 1)
                //{
                //    Console.Write("L" + $"{floorNumber}{appartementNumber} ");
                    
                //    appartementNumber++;
                //    floorNumber--;
                //    continue;

                //}
                for (int r = 0; r < row; r++)
                {
                    if (i == col - 1)
                    {
                        Console.Write("L" + $"{floorNumber}{appartementNumber} ");
                        appartementNumber++;
                        continue;

                    }
                   
                    
                    if (i % 2 == 0)
                    {
                        Console.Write("A" + $"{floorNumber}{appartementNumber} ");
                        appartementNumber++;
                    }
                    else
                    {
                        Console.Write("O" +  $"{floorNumber}{appartementNumber} ");
                        appartementNumber++;
                    }
                }
                appartementNumber = 0;
                floorNumber--;
                Console.WriteLine();
            }
        }
    }
}
