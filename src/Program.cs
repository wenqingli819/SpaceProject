using System;
using SpaceProject.Data.Model;
using SpaceProject.Data.Repository;
using SpaceProject.UI.Controller;

namespace SpaceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // create crew members
            AstronautRepo a = new AstronautRepo();
            Astronaut[] astronauts=a.CreateCrewMember();
            String captain = a.GetCaptainName();
            
            Console.WriteLine("Crew Members are ready");
            Console.WriteLine("Captain is " + captain);
            Console.WriteLine("\n");
            
            // create rockets
            RocketRepo.CreateRockets();
            Console.WriteLine("Rockets created");
            Console.WriteLine("\n");

            // create mission and assign to captain
            MccController mcc = new MccController();
            mcc.CreateMission(captain);
            Console.WriteLine("Mission Created");
            Console.WriteLine("\n");

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
