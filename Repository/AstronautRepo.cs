﻿using System;
using System.Collections.Generic;
using System.Text;
using SpaceProject.Domain;

namespace SpaceProject.Repository
{
    class AstronautRepo
    {
        private Astronaut[] astronauts;
        

        public Astronaut[] createCrewMember()
        {
            astronauts = new Astronaut[3];
            Astronaut a1 = new Astronaut();


            a1.AstroID = 1;
            a1.AstroName = "Jack";
            Role pilot = Role.Pilot;
            a1.Role = pilot;

            Astronaut a2 = new Astronaut();
            a2.AstroID = 2;
            a2.AstroName = "Rose";
            Role missionSpecialist = Role.MissionSpecialist;
            a2.Role = missionSpecialist;


            Astronaut a3 = new Astronaut();
            a3.AstroID = 3;
            a3.AstroName = "Tony";
            Role payloadSpecialist = Role.PayloadSpecialist;
            a2.Role = payloadSpecialist;

            astronauts[0] = a1;
            astronauts[1] = a2;
            astronauts[2] = a3;

            int length = astronauts.Length;
            Console.WriteLine("AstroID \t AstroName \t Role");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(astronauts[i].AstroID + "\t" + "\t"
                    + astronauts[i].AstroName + "\t" + "\t"
                    + astronauts[i].Role);
            }
         

            return astronauts;

        }
        public String GetCaptainName()
        {
            Console.WriteLine(astronauts[0].AstroName);
            if (astronauts[0].AstroName == null)
            {
                Console.WriteLine("No captain.");
                return null;
            }
            else
            {
                Console.WriteLine(astronauts[0].AstroName);
                return astronauts[0].AstroName;
            }
        }
    }
}
