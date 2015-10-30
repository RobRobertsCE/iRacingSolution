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
    public partial class LeaderboardView : UserControl
    {
        [Browsable(false)]
        public LeaderboardViewModel ViewModel
        {
            get
            {
                if (null == this.leaderboardViewModelBindingSource.DataSource)
                    return null;
                else
                    return (LeaderboardViewModel)this.leaderboardViewModelBindingSource.DataSource;
            }
            set
            {
                if (value.GetType() == typeof(LeaderboardViewModel))
                {
                    this.leaderboardViewModelBindingSource.DataSource = value;
                    this.driverView1.ViewModel = value.Driver;
                }                
            }
        }

        public LeaderboardView()
        {
            InitializeComponent();
        }
    }
}
