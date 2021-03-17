using System;
using System.Collections.Generic;
using SpaceProject.Data.Model;

namespace SpaceProject.Data.Repository
{
    public class RocketRepo
    {
        public static void CreateRockets()
        {
            List<Rocket> rockets = new List<Rocket>();
            Rocket r1 = new Rocket(1, "Miner9", MissionType.AsteroidMining);
            Rocket r2 = new Rocket(2, "Mysorean Rocket", MissionType.Research);
            Rocket r3 = new Rocket(3, "Fake Starship", MissionType.Satellites);
            Rocket r4 = new Rocket(4, "Hotel Space", MissionType.Tourism);
            rockets.Add(r1);
            rockets.Add(r2);
            rockets.Add(r3);
            rockets.Add(r4);

            Console.WriteLine("RocketID" + "\t"+"RocketName" + "\t"+"RocketType");
            foreach (var r in rockets)
            {
                Console.WriteLine(r.RocketID+"\t"+"\t"+r.RocketName+"\t"+"\t"+r.MissionType);   
            }

        }
    }
}