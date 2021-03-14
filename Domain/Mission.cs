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
        private DateTime expirationDate;
        private  MissionType type;


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
                return DateTime.Now;
            }
        }

        public DateTime ExpirationDate
        {
            get
            {
                return expirationDate;
            }
            set
            {
                expirationDate = value;
            }
        }

        public MissionType Type { get; set; }
    }
}
