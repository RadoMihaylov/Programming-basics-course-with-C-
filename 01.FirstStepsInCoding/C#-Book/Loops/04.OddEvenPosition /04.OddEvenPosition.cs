using System;

namespace _11.Odd_EvenPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double oddSum = 0;
            double evenMin = double.MaxValue;
            double oddMin = double.MaxValue;
            double evenMax = double.MinValue;
            double oddMax = double.MinValue;


            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)  
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    oddSum+= number;
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }


                }
              
            }
            if (oddSum != 0)
            {
                Console.WriteLine($"OddSum={oddSum}");
            }
            else
            {
                Console.WriteLine($"OddSum={0}");
            }

            if (oddMin == double.MaxValue)
            {
                Console.WriteLine($"OddMin={"No"}");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin}");
            }

            if (oddMax == double.MinValue)
            {
                Console.WriteLine($"OddMax={"No"}");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax}");
            }

            if (evenSum != 0)
            {
                Console.WriteLine($"EvenSum={evenSum}");
            }
            else
            {
                Console.WriteLine($"EvenSum={0}");
            }

            if (evenMin == double.MaxValue)
            {
                Console.WriteLine($"EvenMin={"No"}");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin}");
            }

            if (evenMax == double.MinValue)
            {
                Console.WriteLine($"EvenMax={"No"}");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax}");
            }


        }
    }
}
