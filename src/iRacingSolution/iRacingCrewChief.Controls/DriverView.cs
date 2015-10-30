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
    public partial class DriverView : UserControl
    {
        public bool DisplayTeam
        {
            get
            {
                return this.teamLabel1.Visible;
            }
            set
            {
                this.teamLabel1.Visible = value;
            }
        }
        public bool DisplayClub
        {
            get
            {
                return this.clubLabel1.Visible;
            }
            set
            {
                this.clubLabel1.Visible = value;
            }
        }
        public bool DisplayVehicle
        {
            get
            {
                return this.vehicleLabel1.Visible;
            }
            set
            {
                this.vehicleLabel1.Visible = value;
            }
        }
        [Browsable(false)]
        public DriverViewModel ViewModel
        {
            get
            {
                if (null == this.driverViewModelBindingSource.DataSource)
                    return null;
                else
                    return (DriverViewModel)this.driverViewModelBindingSource.DataSource;
            }
            set
            {
                if (value.GetType() == typeof(DriverViewModel))
                {
                    this.driverViewModelBindingSource.DataSource = value;
                    this.driverToolTip.SetToolTip(this.nameLabel1, ViewModel.DriverLicenseInfo);
                    this.driverToolTip.SetToolTip(this.picLicense, ViewModel.DriverLicenseInfo);
                }
            }
        }

        public DriverView()
        {
            InitializeComponent();
        }
    }
}
