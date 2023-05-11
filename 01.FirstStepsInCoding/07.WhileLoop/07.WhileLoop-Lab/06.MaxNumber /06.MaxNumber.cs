using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;            
            int max = int.MinValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                if (input == "Stop")
                {
                    break;
                }

                int nums = int.Parse(input);
                if (nums > max)
                {
                    max = nums;
                    
                }
                
            }
            Console.WriteLine(max);

        }
    }
}
