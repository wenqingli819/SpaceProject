using SpaceProject.Repository;
using System;

namespace SpaceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AstronautRepo a = new AstronautRepo();
            a.createCrewMember();
            Console.WriteLine("Crew Members are ready.");
        }
    }
}
