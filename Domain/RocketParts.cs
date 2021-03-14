using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceProject.Domain
{
    class RocketParts
    {
        private string[] noseCone;
        private string rocketBody;
        private string engine;
        private string fins;

        public RocketParts()
        {

        }


        public string[] NoseCone
        {

            get
            {
                return noseCone;
            }
            set
            {
                noseCone = value;
            }
        }

        public string RocketBody
        {

            get
            {
                return rocketBody;
            }
            set
            {
                rocketBody = value;
            }
        }

        public string Engine
        {

            get
            {
                return engine;
            }
            set
            {
                engine = value;
            }
        }

        public string Fins
        {

            get
            {
                return fins;
            }
            set
            {
                fins = value;
            }
        }



    }
}
