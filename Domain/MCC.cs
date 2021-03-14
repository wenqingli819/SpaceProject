using System;
using System.Collections.Generic;
using System.Text;
using SpaceProject.Repository;

namespace SpaceProject.Domain
{
    // MCC stands for Mission Control Center
    class MCC
    {
        private const string BOSS="boss";

        // should not contain any data or implementation in domain,
        // right now just for practice convinence and not using layers
        public static void AssignMissionToAstronauts()
        {
            AstronautRepo arepo = new AstronautRepo();
            String personInCharge = arepo.GetCaptainName();
            MissionType type = MissionType.AsteroidMining;
            DateTime createDate = DateTime.Now;
            DateTime expireDate = new DateTime(2025, 1, 18);
           
            Mission m = new Mission(1, "learn to fly", "first space mission", personInCharge, 9999999M,createDate, expireDate, type);
            Console.WriteLine("Mission created:");
            Console.WriteLine(m);
        } 
    }
}
