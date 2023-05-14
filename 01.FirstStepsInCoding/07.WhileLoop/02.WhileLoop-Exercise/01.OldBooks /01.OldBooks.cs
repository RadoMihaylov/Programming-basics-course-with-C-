using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            string nextBook = Console.ReadLine();            
            int count = 0; 
            bool isFound = false;

            while (nextBook != "No More Books")
            {
                if (nextBook == bookName)
                {
                    isFound = true;                    
                    break;
                }
                count++;
                nextBook = Console.ReadLine();
            }
            
            if (isFound)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }


        }
    }
}
