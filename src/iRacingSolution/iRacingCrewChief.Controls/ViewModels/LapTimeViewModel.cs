using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingCrewChief.Controls.ViewModels
{
    public class LapTimeViewModel
    {
        public int CarNumber { get; set; }
        public int LapNumber { get; set; }
        public Single Interval { get; set; }
        public Single LapTime { get; set; }
        public Single LapMPH { get; set; }
        public string FlagState { get; set; }
        public LapTimeViewModel LastLap { get; set; }
        // read only 
        public Single LapTimeDelta
        {
            get
            {
                if (null == LastLap)
                    return 0.0F;
                else
                    return LastLap.LapTime - LapTime;
            }
        }
        public Single LapMPHDelta
        {
            get
            {
                if (null == LastLap)
                    return 0.0F;
                else
                    return LastLap.LapMPH - LapMPH;
            }
        }
    }
}
