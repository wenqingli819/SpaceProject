using System;

namespace SpaceProject.Data.Model
{
    // MCC is the boss, it stands for Mission Control Center
    // singleton MCC to ensure only one object of MCC in the system.
    class MCC
    {

        private MCC(){}
        private static MCC mcc = null;
        
        public static MCC GetInstance()
        {
            if (mcc == null)
            {
                mcc = new MCC();
            }
            return mcc;
        }
        
        
    }
}
