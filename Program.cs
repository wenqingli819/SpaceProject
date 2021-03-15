using SpaceProject.Repository;
using System;
using SpaceProject.Domain;
using SpaceProject.Singleton;

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

            MCC mcc = MCC.GetInstance();
            mcc.AssignMissionToAstronauts(captain);


            //test singleton
            MCC mcc1 = MCC.GetInstance();
            MCC mcc2 = MCC.GetInstance();

            if (mcc1 == mcc2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
