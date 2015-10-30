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
    public partial class SessionStatusView : UserControl
    {
        public SessionStateViewModel ViewModel
        {
            get
            {
                if (null == this.sessionStateViewModelBindingSource.DataSource)
                    return null;
                else
                    return (SessionStateViewModel)this.sessionStateViewModelBindingSource.DataSource;
            }
            set
            {
                if (value.GetType() == typeof(SessionStateViewModel))
                {
                    this.sessionStateViewModelBindingSource.DataSource = value;
                }
            }
        }

        public SessionStatusView()
        {
            InitializeComponent();
        }
    }
}
