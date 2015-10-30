using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingCrewChief.Controls.ViewModels
{
    public class LeaderboardViewModel
    {
        public int Position { get; set; }
        public int ClassPosition { get; set; }
        public DriverViewModel Driver { get; set; }
        public LapTimeViewModel Lap { get; set; }
        public Single IntervalToNext { get; set; }
    }
}
