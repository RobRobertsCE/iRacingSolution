using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iRacingCrewChief.Controls.ViewModels;

namespace iRacingCrewChief.Controls
{
    public partial class LapTimeView : UserControl
    {
        public bool DisplayLapTimeDelta
        {
            get
            {
                return this.lapTimeDeltaLabel1.Visible;
            }
            set
            {
                this.lapTimeDeltaLabel1.Visible = value;
            }
        }
        public bool DisplayLapMPHDelta
        {
            get
            {
                return this.lapMPHDeltaLabel1.Visible;
            }
            set
            {
                this.lapMPHDeltaLabel1.Visible = value;
            }
        }
        public bool DisplayLapMPH
        {
            get
            {
                return this.lapMPHLabel1.Visible;
            }
            set
            {
                this.lapMPHLabel1.Visible = value;
            }
        }
        public bool DisplayInterval
        {
            get
            {
                return this.intervalLabel1.Visible;
            }
            set
            {
                this.intervalLabel1.Visible = value;
            }
        }
        [Browsable(false)]
        public LapTimeViewModel ViewModel
        {
            get
            {
                if (null == this.lapTimeViewModelBindingSource.DataSource)
                    return null;
                else
                    return (LapTimeViewModel)this.lapTimeViewModelBindingSource.DataSource;
            }
            set
            {
                if (value.GetType() == typeof(LapTimeViewModel))
                {
                    this.lapTimeViewModelBindingSource.DataSource = value;
                }
            }
        }

        public LapTimeView()
        {
            InitializeComponent();
            this.lapMPHDeltaLabel1.DataBindings[0].Format += LapTimeView_MPHDelta_Format;
            this.lapTimeDeltaLabel1.DataBindings[0].Format += LapTimeView_LapTimeDelta_Format;
        }

        void LapTimeView_MPHDelta_Format(object sender, ConvertEventArgs e)
        {
            if ((Single)e.Value == 0)
                this.lapMPHDeltaLabel1.ForeColor = Color.Black;
            else if ((Single)e.Value > 0)
                this.lapMPHDeltaLabel1.ForeColor = Color.Green;
            else
                this.lapMPHDeltaLabel1.ForeColor = Color.Red;
        }

        void LapTimeView_LapTimeDelta_Format(object sender, ConvertEventArgs e)
        {
            if ((Single)e.Value == 0)
                this.lapTimeDeltaLabel1.ForeColor = Color.Black;
            else if ((Single)e.Value > 0)
                this.lapTimeDeltaLabel1.ForeColor = Color.Green;
            else
                this.lapTimeDeltaLabel1.ForeColor = Color.Red;
        }
    }
}
