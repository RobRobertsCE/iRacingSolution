using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingCrewChief.Controls.ViewModels
{
    public enum TirePosition
    {
        LeftFront,
        LeftRear,
        RightFront,
        RightRear
    }

    public class PitStopViewModel
    {
        public PitStopChanges Current { get; set; }
        public PitStopChanges Pending { get; set; }

        public bool HasPendingChanges
        {
            get
            {
                return (HasFuelChange || HasWindshieldChange || HasTireChanges || HasTapeChange || HasTrackBarChange || HasWedgeChange);
            }
        }
        public bool HasFuelChange
        {
            get
            {
                return (Current.AddFuel == Pending.AddFuel && Current.FuelToAdd == Pending.FuelToAdd);
            }
        }
        public bool HasWindshieldChange
        {
            get
            {
                return (Current.CleanWindshield == Pending.CleanWindshield);
            }
        }
        public bool HasTireChanges
        {
            get
            {
                return ( HasLFTireChange || HasLRTireChange || HasRFTireChange || HasRRTireChange);
            }
        }
        public bool HasLFTireChange
        {
            get
            {
                return (Current.Tires.LF.Equals(Pending.Tires.LF));
            }
        }
        public bool HasLRTireChange
        {
            get
            {
                return (Current.Tires.LR.Equals(Pending.Tires.LR));
            }
        }
        public bool HasRFTireChange
        {
            get
            {
                return (Current.Tires.RF.Equals(Pending.Tires.RF));
            }
        }
        public bool HasRRTireChange
        {
            get
            {
                return (Current.Tires.RR.Equals(Pending.Tires.RR));
            }
        }
        public bool HasTapeChange
        {
            get
            {
                return (Current.TapeSetting == Pending.TapeSetting);
            }
        }
        public bool HasTrackBarChange
        {
            get
            {
                return (Current.TrackBarAdjustment  == Pending.TrackBarAdjustment);
            }
        }
        public bool HasWedgeChange
        {
            get
            {
                return (Current.LRWedgeAdjustment  == Pending.LRWedgeAdjustment && Current.RRWedgeAdjustment == Pending.RRWedgeAdjustment);
            }
        }

        public PitStopViewModel()
        {
            Current = new PitStopChanges();
            Pending = new PitStopChanges();
        }
    }

    public class PitStopChanges
    {
        public bool ChangesSent { get; set; }
        public PitStopTires Tires { get; set; }
        public bool AddFuel { get; set; }
        public float FuelToAdd { get; set; }
        public bool ChangeTape { get; set; }
        public float TapeSetting { get; set; }
        public bool CleanWindshield { get; set; }
        public bool FastRepairOn { get; set; }
        public Single RRWedgeAdjustment { get; set; }
        public Single LRWedgeAdjustment { get; set; }
        public Single TrackBarAdjustment { get; set; }

        public PitStopChanges()
        {
            Tires = new PitStopTires();
        }
    }

    public class PitStopTires
    {
        private IList<PitStopTire> _tires;
        public PitStopTire LF
        {
            get
            {
                return _tires[(int)TirePosition.LeftFront];
            }
            set
            {
                _tires[(int)TirePosition.LeftFront] = value;
            }
        }
        public PitStopTire LR
        {
            get
            {
                return _tires[(int)TirePosition.LeftRear];
            }
            set
            {
                _tires[(int)TirePosition.LeftRear] = value;
            }
        }
        public PitStopTire RF
        {
            get
            {
                return _tires[(int)TirePosition.RightFront];
            }
            set
            {
                _tires[(int)TirePosition.RightFront] = value;
            }
        }
        public PitStopTire RR
        {
            get
            {
                return _tires[(int)TirePosition.RightRear];
            }
            set
            {
                _tires[(int)TirePosition.RightRear] = value;
            }
        }

        public PitStopTires()
        {
            _tires = new List<PitStopTire>();
            _tires.Add(new PitStopTire() { Position = TirePosition.LeftFront });
            _tires.Add(new PitStopTire() { Position = TirePosition.LeftRear });
            _tires.Add(new PitStopTire() { Position = TirePosition.RightFront });
            _tires.Add(new PitStopTire() { Position = TirePosition.RightRear });
        }

        public void ChangeAll4()
        {
            LF.ChangeTire = true;
            LR.ChangeTire = true;
            RF.ChangeTire = true;
            RR.ChangeTire = true;
        }

        public void ChangeRights()
        {
            RF.ChangeTire = true;
            RR.ChangeTire = true;
        }

        public void Clear()
        {
            foreach (var tire in _tires)
            {
                tire.ChangeTire = false;
                tire.ChangePSI = 0.0F;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class PitStopTire
    {
        public TirePosition Position { get; set; }
        public float ChangePSI { get; set; }
        public bool ChangeTire { get; set; }

        public override bool Equals(object obj)
        {
            try
            {
                PitStopTire compare = (PitStopTire)obj;
                return (compare.ChangePSI == ChangePSI && compare.ChangeTire == ChangeTire);
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
