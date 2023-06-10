using System;
using System.Diagnostics.Tracing;

namespace _04.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());          
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int doctors = 7;

            for (int i = 1; i <= period; i++)
            {
                int countOfPatients = int.Parse(Console.ReadLine());

                if ((i % 3 == 0) && (untreatedPatients > treatedPatients))
                {
                    doctors++;
                }

                if (countOfPatients > doctors)
                {
                    treatedPatients += doctors;
                    untreatedPatients += countOfPatients - doctors;
                }
                else
                {
                    treatedPatients += countOfPatients;
                }

            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
