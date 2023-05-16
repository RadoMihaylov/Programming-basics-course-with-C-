using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isFinish = false;
            int steps = 0;
            int sumOfSteps = 0;
            string input = null;
            int lastSteps = 0;
            

            while (sumOfSteps < 10000)
            {
                input = Console.ReadLine();

                if (input == "Going home")
                {
                    lastSteps = int.Parse(Console.ReadLine());
                    sumOfSteps += lastSteps;
                    isFinish = true;
                    if (sumOfSteps >= 10000)
                    {
                        isFinish = false;
                    }
                    break;

                }
                else if (input != "Going home")
                {
                    steps = int.Parse(input);
                    sumOfSteps += steps;
                }

            }
            int diffBetweenTheSteps = Math.Abs(sumOfSteps - 10000);

            if (isFinish)
            {
                Console.WriteLine($"{diffBetweenTheSteps} more steps to reach goal.");
            }
            else if (isFinish == false)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{diffBetweenTheSteps} steps over the goal!");
            }
                
   
        }
    }
}
