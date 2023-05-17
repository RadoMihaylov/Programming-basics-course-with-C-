using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());  
            int lenght = int.Parse(Console.ReadLine());
            int takingPieces = 0;
            bool isTheyTaken = false;
            int sumOfPieces = 0;
            int countOfPieces = widht * lenght; 
            
            while (countOfPieces > sumOfPieces )
            {
                string command = Console.ReadLine();
              
                if (command == "STOP")
                {
                   isTheyTaken= true;
                    break;
                }
                int takenPiecesInOneTake = int.Parse(command);
                takingPieces += takenPiecesInOneTake;
                sumOfPieces = countOfPieces - takingPieces;
                if (sumOfPieces <=0 )
                {
                    break;
                }
            }

            if (isTheyTaken)
            {
                Console.WriteLine($"{sumOfPieces} pieces are left.");
            }
            else
            {
                int missingPieces = Math.Abs((sumOfPieces + countOfPieces) - countOfPieces);
                Console.WriteLine($"No more cake left! You need {missingPieces} pieces more.");
            }
        }
    }
}
