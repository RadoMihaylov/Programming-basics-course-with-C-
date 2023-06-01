using System;

namespace _03.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }
    }
}
