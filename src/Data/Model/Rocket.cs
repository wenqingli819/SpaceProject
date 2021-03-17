namespace SpaceProject.Data.Model
{
    class Rocket
    {
        private int rocketID;
        private string rocketName;
        private MissionType missionType;

        public Rocket(int rocketId, string rocketName, MissionType missionType)
        {
            rocketID = rocketId;
            this.rocketName = rocketName;
            this.missionType = missionType;
        }

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
        public MissionType MissionType
        {
            get => missionType;
            set => missionType = value;
        }


    }
}
