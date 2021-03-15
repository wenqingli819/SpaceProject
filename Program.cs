using SpaceProject.Repository;
using System;
using SpaceProject.Domain;

namespace SpaceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AstronautRepo a = new AstronautRepo();
            Astronaut[] astronauts=a.CreateCrewMember();
            String captain = a.GetCaptainName();
            
            Console.WriteLine("Crew Members are ready.");
            Console.WriteLine("Captain is " + captain);

            MCC.AssignMissionToAstronauts(captain);
        }
    }
}
