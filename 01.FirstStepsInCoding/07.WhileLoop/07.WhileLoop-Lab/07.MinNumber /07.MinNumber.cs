using System;

namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minValue = int.MaxValue;
            
            while (input != "Stop")
            {
                int nums = int.Parse(input);
                if (nums < minValue)
                {
                    minValue = nums;
                    
                }

                else if (input == "Stop")
                {
                    break;
                }               
                input = Console.ReadLine();
                
            }
            Console.WriteLine(minValue);

        }
    }
}
