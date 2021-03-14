using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceProject.Domain
{
    public enum Role
    {
        Pilot,
        MissionSpecialist,
        PayloadSpecialist
    }
    class Astronaut
    {
        private int astroID;
        private string astroName;
        private Role role;

        // properties, include getters and setters
        public int AstroID
        {

            get
            {
                return astroID;
            }
            set
            {
                astroID = value;
            }
        }
        public string AstroName
        {

            get
            {
                return astroName;
            }
            set
            {
                astroName = value;
            }
        }
        public Role Role
        {

            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }

        public static void receiveMissionFromMCC(){
        }

        public static void divideMissionIntoTasks()
        {
        }
    }
}
