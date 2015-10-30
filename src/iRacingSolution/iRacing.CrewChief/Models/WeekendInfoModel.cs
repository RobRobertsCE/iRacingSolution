﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacing.CrewChief.Models
{
    [Serializable]
    public class WeekendInfoModel
    {
        public string TrackName { get; set; }
        public long TrackID { get; set; }
        public string TrackLength { get; set; }
        public string TrackDisplayName { get; set; }
        public string TrackDisplayShortName { get; set; }
        public string TrackConfigName { get; set; }
        public string TrackCity { get; set; }
        public string TrackCountry { get; set; }
        public string TrackAltitude { get; set; }
        public string TrackLatitude { get; set; }
        public string TrackLongitude { get; set; }
        public long TrackNumTurns { get; set; }
        public string TrackPitSpeedLimit { get; set; }
        public string TrackType { get; set; }
        public string TrackWeatherType { get; set; }
        public string TrackSkies { get; set; }
        public string TrackSurfaceTemp { get; set; }
        public string TrackAirTemp { get; set; }
        public string TrackAirPressure { get; set; }
        public string TrackWindVel { get; set; }
        public string TrackWindDir { get; set; }
        public string TrackRelativeHumidity { get; set; }
        public string TrackFogLevel { get; set; }
        public long SeriesID { get; set; }
        public long SeasonID { get; set; }
        public long SessionID { get; set; }
        public long SubSessionID { get; set; }
        public long LeagueID { get; set; }
        public long Official { get; set; }
        public long RaceWeek { get; set; }
        public string EventType { get; set; }
        public string Category { get; set; }
        public string SimMode { get; set; }
        public long TeamRacing { get; set; }
        public long MinDrivers { get; set; }
        public long MaxDrivers { get; set; }
        public string DCRuleSet { get; set; }
        public long QualifierMustStartRace { get; set; }
        public long NumCarClasses { get; set; }
        public long NumCarTypes { get; set; }

        public WeekendOptionsModel WeekendOptions { get; set; }

        public TelemetryOptionsModel TelemetryOptions { get; set; }
    }
}
