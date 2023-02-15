using System;
using System.ComponentModel;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           	//"The architect {името на архитекта} will need {необходими часове} " +
            //"hours to complete {брой на проектите} project/s."

            string architectName = Console.ReadLine(); 
            int projectsCount = int.Parse(Console.ReadLine());
            int timeForProject = 3;

            int mustTimeForProjects = projectsCount * timeForProject;
            Console.WriteLine($"The architect {architectName} will need {mustTimeForProjects}" +
                              $" hours to complete {projectsCount} project/s.");
        }
    }
}
