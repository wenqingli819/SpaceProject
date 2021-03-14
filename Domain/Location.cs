using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceProject.Domain
{
    class Location
    {
        // ignore for now
        // maybe can get Latitude,Longitude,Altitude from some api?
        private int locationID;
        

        public int LocationID
        {
            get
            {
                return locationID;
            }
            set
            {
                locationID = value;
            }
        }
    }
}
