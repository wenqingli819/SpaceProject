using System;
using SpaceProject.Data.Model;
namespace SpaceProject.UI.Controller
{
    public class MccController
    {
        //MCC mcc = MCC.GetInstance();

        public void CreateMission(String captain)
        {
            String personInCharge = captain;
            MissionType type = MissionType.AsteroidMining;
            DateTime expireDate = new DateTime(2025, 1, 18);
           
            Mission m = new Mission(1, "learn to fly", "first space mission", personInCharge, 9999999M, expireDate, type);
            Console.WriteLine("Mission created:");

            //Console.WriteLine(m); //error
            foreach(var prop in m.GetType().GetProperties()){
                Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(m, null));
            }
        } 
    }
}