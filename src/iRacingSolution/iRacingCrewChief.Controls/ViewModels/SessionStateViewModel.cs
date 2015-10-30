using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingCrewChief.Controls.ViewModels
{
    public class SessionStateViewModel
    {
        public string TrackName { get; set; }
        public Single TrackLength { get; set; }

        public string SessionName { get; set; }
        public int SessionNumber { get; set; }
        public string SessionState { get; set; }
        public string WeatherSummary { get; set; }
        public string DriverName { get; set; }
        public string VehicleDescription { get; set; }

        public int SessionLapLimit { get; set; }
        public int CurrentLapNumber { get; set; }

        public bool IsLapLimitedSession { get; set; }
        public bool IsTimedSession { get; set; }
        public TimeSpan SessionTimeRemaining { get; set; }

        public bool IsFixedSetup { get; set; }
        public string SetupName { get; set; }

        public string LapsRemainingCaption
        {
            get
            {
                return String.Format("{0} of {1}", CurrentLapNumber, SessionLapLimit);
            }
        }
    }
}
