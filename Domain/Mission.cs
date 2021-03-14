using System;
using System.Collections.Generic;
using System.Text;
using SpaceProject.Domain;

namespace SpaceProject.Domain
{
    public enum MissionType
    {
        Research,
        AsteroidMining,
        Satellites,
        Tourism
    }
    class Mission
    {
        private int missionID;
        private string missionName;
        private string description;
        private string peronInCharge;
        private decimal budget;
        private readonly DateTime createDate;
        private DateTime expireDate;
        private MissionType type;

        //constructor
        public Mission() { }

        public Mission(int missionID, string missionName, string description, string peronInCharge, decimal budget, DateTime createDate, DateTime expireDate, MissionType type)
        {
            this.missionID = missionID;
            this.missionName = missionName;
            this.description = description;
            this.peronInCharge = peronInCharge;
            this.budget = budget;
            this.createDate = createDate;
            this.expireDate = expireDate;
            this.type = type;
        }


        // properties
        public int MissionId
        {
            get
            {
                return missionID;
            }
            set
            {
                missionID = value;
            }
        }

        public string MissionName
        {
            get
            {
                return missionName;
            }
            set
            {
                missionName = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string PeronInCharge
        {
            get
            {
                return peronInCharge;
            }
            set
            {
                peronInCharge = value;
            }
        }

        public decimal Budget
        {
            get
            {
                return budget;
            }
            set
            {
                budget = value;
            }
        }

        public DateTime CreateDate {
            get
            {
                return createDate;
            }
        }

        public DateTime ExpireDate
        {
            get
            {
                return expireDate;
            }
            set
            {
                expireDate = value;
            }
        }

        public MissionType Type { 

            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }
}
