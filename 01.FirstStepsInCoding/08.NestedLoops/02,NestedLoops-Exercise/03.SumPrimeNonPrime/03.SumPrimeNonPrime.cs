using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int primeNumber = 0, nonPrimeNumber = 0;
            string input = Console.ReadLine();

            while (input != "stop")
            {
                int num = int.Parse(input);

                if (num < 0 )
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    double sqrt  = Math.Sqrt(num);
                    bool isPrime = true;
                    for (int i = 2; i <= sqrt; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;                            
                        }
                        
                    }
                    if (isPrime)
                    {
                        primeNumber += num;
                    }
                    else
                    {
                        nonPrimeNumber+= num;
                    }
                }
                
                input= Console.ReadLine();

            }

            Console.WriteLine($"Sum of all prime numbers is: {primeNumber}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumber}");
        }
    }
}
