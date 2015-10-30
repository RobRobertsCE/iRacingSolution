using iRacing.Models.Telemetry;
using iRacingCrewChief.Controls.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingCrewChief.Controls.Handlers
{
    public class PitStopHandler : INotifyPropertyChanged
    {
        PitStopViewModel _viewModel;
        public PitStopViewModel ViewModel
        {
            get
            {
                return _viewModel;
            }
            set
            {
                _viewModel = value;
                OnPropertyChanged("ViewModel");
            }
        }

        public delegate void RequestPitStopChangesEvent(object sender, RequestPitStopChangesArgs e);
        public event EventHandler<RequestPitStopChangesArgs> RequestPitStopChanges;
        void OnRequestPitStopChanges(PitStopViewModel viewModel)
        {
            var handler = this.RequestPitStopChanges;
            if (null != handler)
                this.RequestPitStopChanges.Invoke(this, new RequestPitStopChangesArgs() { ViewModel = viewModel });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (null != handler)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SubmitChanges()
        {
            OnRequestPitStopChanges(ViewModel);
        }

        public void HandleTelemetryFrame(ITelemetry telemetry)
        {
            UpdateCurrent(ViewModel.Current, telemetry);
        }

        void UpdateCurrent(PitStopChanges current, ITelemetry telemetry)
        {
            current.CleanWindshield = ((PitCommandMode)telemetry.PitSvFlags).HasFlag(PitCommandMode.Windshield);
            current.AddFuel = ((PitCommandMode)telemetry.PitSvFlags).HasFlag(PitCommandMode.Fuel);
            current.FastRepairOn = ((PitCommandMode)telemetry.PitSvFlags).HasFlag(PitCommandMode.FastRepair);
            current.FuelToAdd = telemetry.PitSvFuel;
            current.TapeSetting = telemetry.dpQtape;
            current.LRWedgeAdjustment = telemetry.dpLrWedgeAdj;
            current.RRWedgeAdjustment = telemetry.dpRrWedgeAdj;
            current.TrackBarAdjustment = telemetry.dpRBarSetting;

            current.Tires.LF.ChangeTire = ((PitCommandMode)telemetry.PitSvFlags).HasFlag(PitCommandMode.LeftFront);
            current.Tires.LF.ChangePSI = telemetry.PitSvLFP;
            current.Tires.LR.ChangeTire = ((PitCommandMode)telemetry.PitSvFlags).HasFlag(PitCommandMode.LeftRear);
            current.Tires.LR.ChangePSI = telemetry.PitSvLRP;
            current.Tires.RF.ChangeTire = ((PitCommandMode)telemetry.PitSvFlags).HasFlag(PitCommandMode.RightFront);
            current.Tires.RF.ChangePSI = telemetry.PitSvRFP;
            current.Tires.RR.ChangeTire = ((PitCommandMode)telemetry.PitSvFlags).HasFlag(PitCommandMode.RightRear);
            current.Tires.RR.ChangePSI = telemetry.PitSvRRP;
        }

        public PitStopHandler()
        {
            _viewModel = new PitStopViewModel();
        }
    }

    public class RequestPitStopChangesArgs : EventArgs
    {
        public PitStopViewModel ViewModel { get; set; }
    }
    public enum PitCommandMode
    {
        /// <summary>
        /// Clear all pit checkboxes
        /// </summary>
        Clear = 0,
        /// <summary>
        /// Clean the winshield, using one tear off
        /// </summary>
        Windshield,
        /// <summary>
        /// Add fuel, optionally specify the amount to add in liters or pass '0' to use existing amount
        /// </summary>
        Fuel,
        /// <summary>
        /// Change the left front tire, optionally specifying the pressure in KPa or pass '0' to use existing pressure
        /// </summary>
        LeftFront,
        /// <summary>
        /// Change the right front tire, optionally specifying the pressure in KPa or pass '0' to use existing pressure
        /// </summary>
        RightFront,
        /// <summary>
        /// Change the left rear tire, optionally specifying the pressure in KPa or pass '0' to use existing pressure
        /// </summary>
        LeftRear,
        /// <summary>
        /// Change the right rear tire, optionally specifying the pressure in KPa or pass '0' to use existing pressure
        /// </summary>
        RightRear,
        /// <summary>
        /// Clear tire pit checkboxes tire, optionally specifying the pressure in KPa or pass '0' to use existing pressure
        /// </summary>
        ClearTires,
        FastRepair
    };
}
