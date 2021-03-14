using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceProject.Domain
{
    class Rocket
    {
        private int rocketID;
        private string rocketName;


        public int RocketID
        {

            get
            {
                return rocketID;
            }
            set
            {
                rocketID = value;
            }
        }

        public string RocketName
        {

            get
            {
                return rocketName;
            }
            set
            {
                rocketName = value;
            }
        }



    }
}
