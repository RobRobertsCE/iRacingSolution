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
using iRacingCrewChief.Controls.Handlers;

namespace iRacingCrewChief.Controls
{
    public partial class PitStopSetupView : UserControl
    {
        private bool _hasChanges;
        public bool HasChanges
        {
            get
            {
                return _hasChanges;
            }
            set
            {
                _hasChanges = value;
                HighlightChanges();
            }
        }

        PitStopHandler _handler;
        public PitStopHandler Handler
        {
            get
            {
                return _handler;
            }
            set
            {
                _handler = value;
                this.pitStopViewModelBindingSource.DataSource = _handler.ViewModel;
            }
        }

        public PitStopSetupView(PitStopHandler handler)
            : this()
        {
            this.Handler = handler;
        }

        public PitStopSetupView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Handler.SubmitChanges();
        }

        private void HighlightChanges()
        {
            Color fontColor = (HasChanges ? Color.Blue: Color.Black);
            lblPending.ForeColor = fontColor;
        }
    }
}
