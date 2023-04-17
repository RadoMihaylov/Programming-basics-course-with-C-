using System;
using System.ComponentModel.DataAnnotations;

namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int value = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];
                switch (currentLetter)
                {
                    case 'a': value += 1; break;
                    case 'e': value += 2; break;
                    case 'i': value += 3; break;
                    case 'o': value += 4; break;
                    case 'u': value += 5; break;
                }
            }
            Console.WriteLine(value);
        }
    }
}
