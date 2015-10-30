﻿// This file is part of iRacingSDK.
//
// Copyright 2014 Dean Netherton
// https://github.com/vipoo/iRacingSDK.Net
//
// iRacingSDK is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// iRacingSDK is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with iRacingSDK.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using iRacing.Models;

namespace iRacing
{
    public static partial class DataSampleExtensions
    {
        /// <summary>
        /// Move to start of Race.
        /// Then advances the game through each incident until the end of race, or until NextIncident fails to advance
        /// Then does the same in reverse order (from race end to race start) - to ensure we get all incidents.
        /// </summary>
        /// <param name="samples"></param>
        /// <param name="maxTotalIncidents"></param>
        /// <returns>Return a DataSample of each frame that an identified incident occured on.</returns>
        public static IEnumerable<DataSample> RaceIncidents(this IEnumerable<DataSample> samples, int maxTotalIncidents = int.MaxValue)
        {
            var sessionNumber = GetSessionNumber(samples);

            var incidentsOnForward = GetIncidentsForward(samples, maxTotalIncidents);

            var incidentsOnReverse = GetIncidentsReverse(samples, sessionNumber, maxTotalIncidents - incidentsOnForward.Count);

            var incidents = incidentsOnForward
                .Concat(incidentsOnReverse)
                .OrderBy(d => d.Telemetry.ReplayFrameNum)
                .ToList();

            foreach (var incident in incidents)
                Trace.WriteLine(string.Format("Found new incident at frame {0} for {1}", incident.Telemetry.SessionTimeSpan, incident.Telemetry.CamCar.Details.UserName), "DEBUG");

            return incidents;
        }

        static int GetSessionNumber(IEnumerable<DataSample> samples)
        {
            var data = samples.First();
            return data.Telemetry.SessionNum;
        }

        static List<DataSample> GetIncidentsForward(IEnumerable<DataSample> samples, int maxTotalIncidents)
        {
            return IncidentsSupport.FindIncidents(
                samples.TakeWhile(data => data.Telemetry.SessionState != SessionState.CoolDown),
                d => iRacing.Replay.MoveToNextIncident(),
                maxTotalIncidents);
        }

        static List<DataSample> GetIncidentsReverse(IEnumerable<DataSample> samples, int sessionNumber, int maxTotalIncidents)
        {
            return IncidentsSupport.FindIncidents(
                samples.TakeWhile(data => data.Telemetry.SessionNum == sessionNumber && data.Telemetry.RaceLaps > 0),
                d => iRacing.Replay.MoveToPrevIncident(),
                maxTotalIncidents);
        }
    }
}
