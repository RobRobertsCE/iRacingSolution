namespace iRacingCrewChief.Controls
{
    partial class LeaderboardView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.positionLabel1 = new System.Windows.Forms.Label();
            this.carNumberLabel1 = new System.Windows.Forms.Label();
            this.intervalToNextLabel1 = new System.Windows.Forms.Label();
            this.lapTimeLabel1 = new System.Windows.Forms.Label();
            this.lapTimeDeltaLabel1 = new System.Windows.Forms.Label();
            this.lapMPHLabel1 = new System.Windows.Forms.Label();
            this.lapMPHDeltaLabel1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.intervalLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leaderboardViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverView1 = new iRacingCrewChief.Controls.DriverView();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // positionLabel1
            // 
            this.positionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaderboardViewModelBindingSource, "TirePosition", true));
            this.positionLabel1.Location = new System.Drawing.Point(8, 4);
            this.positionLabel1.Name = "positionLabel1";
            this.positionLabel1.Size = new System.Drawing.Size(40, 23);
            this.positionLabel1.TabIndex = 2;
            this.positionLabel1.Text = "[pos]";
            this.positionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // carNumberLabel1
            // 
            this.carNumberLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carNumberLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaderboardViewModelBindingSource, "Lap.CarNumber", true));
            this.carNumberLabel1.Location = new System.Drawing.Point(56, 4);
            this.carNumberLabel1.Name = "carNumberLabel1";
            this.carNumberLabel1.Size = new System.Drawing.Size(40, 23);
            this.carNumberLabel1.TabIndex = 3;
            this.carNumberLabel1.Text = "[car#]";
            this.carNumberLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // intervalToNextLabel1
            // 
            this.intervalToNextLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intervalToNextLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaderboardViewModelBindingSource, "IntervalToNext", true));
            this.intervalToNextLabel1.Location = new System.Drawing.Point(104, 4);
            this.intervalToNextLabel1.Name = "intervalToNextLabel1";
            this.intervalToNextLabel1.Size = new System.Drawing.Size(75, 23);
            this.intervalToNextLabel1.TabIndex = 5;
            this.intervalToNextLabel1.Text = "[interval]";
            this.intervalToNextLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lapTimeLabel1
            // 
            this.lapTimeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lapTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaderboardViewModelBindingSource, "Lap.LapTime", true));
            this.lapTimeLabel1.Location = new System.Drawing.Point(88, 4);
            this.lapTimeLabel1.Name = "lapTimeLabel1";
            this.lapTimeLabel1.Size = new System.Drawing.Size(75, 23);
            this.lapTimeLabel1.TabIndex = 7;
            this.lapTimeLabel1.Text = "[laptime]";
            this.lapTimeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lapTimeDeltaLabel1
            // 
            this.lapTimeDeltaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lapTimeDeltaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaderboardViewModelBindingSource, "Lap.LapTimeDelta", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.lapTimeDeltaLabel1.Location = new System.Drawing.Point(169, 4);
            this.lapTimeDeltaLabel1.Name = "lapTimeDeltaLabel1";
            this.lapTimeDeltaLabel1.Size = new System.Drawing.Size(75, 23);
            this.lapTimeDeltaLabel1.TabIndex = 8;
            this.lapTimeDeltaLabel1.Text = "[laptimedelta]";
            this.lapTimeDeltaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lapMPHLabel1
            // 
            this.lapMPHLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lapMPHLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaderboardViewModelBindingSource, "Lap.LapMPH", true));
            this.lapMPHLabel1.Location = new System.Drawing.Point(250, 4);
            this.lapMPHLabel1.Name = "lapMPHLabel1";
            this.lapMPHLabel1.Size = new System.Drawing.Size(75, 23);
            this.lapMPHLabel1.TabIndex = 9;
            this.lapMPHLabel1.Text = "[lapmph]";
            this.lapMPHLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lapMPHDeltaLabel1
            // 
            this.lapMPHDeltaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lapMPHDeltaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaderboardViewModelBindingSource, "Lap.LapMPHDelta", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.lapMPHDeltaLabel1.Location = new System.Drawing.Point(331, 4);
            this.lapMPHDeltaLabel1.Name = "lapMPHDeltaLabel1";
            this.lapMPHDeltaLabel1.Size = new System.Drawing.Size(75, 23);
            this.lapMPHDeltaLabel1.TabIndex = 11;
            this.lapMPHDeltaLabel1.Text = "[lapmphdelta]";
            this.lapMPHDeltaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.intervalLabel1);
            this.flowLayoutPanel1.Controls.Add(this.lapTimeLabel1);
            this.flowLayoutPanel1.Controls.Add(this.lapTimeDeltaLabel1);
            this.flowLayoutPanel1.Controls.Add(this.lapMPHLabel1);
            this.flowLayoutPanel1.Controls.Add(this.lapMPHDeltaLabel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(464, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(414, 32);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // intervalLabel1
            // 
            this.intervalLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intervalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leaderboardViewModelBindingSource, "Lap.Interval", true));
            this.intervalLabel1.Location = new System.Drawing.Point(7, 4);
            this.intervalLabel1.Name = "intervalLabel1";
            this.intervalLabel1.Size = new System.Drawing.Size(75, 23);
            this.intervalLabel1.TabIndex = 12;
            this.intervalLabel1.Text = "[interval]";
            this.intervalLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.driverView1);
            this.panel1.Controls.Add(this.positionLabel1);
            this.panel1.Controls.Add(this.carNumberLabel1);
            this.panel1.Controls.Add(this.intervalToNextLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 32);
            this.panel1.TabIndex = 13;
            // 
            // leaderboardViewModelBindingSource
            // 
            this.leaderboardViewModelBindingSource.DataSource = typeof(iRacingCrewChief.Controls.ViewModels.LeaderboardViewModel);
            // 
            // driverView1
            // 
            this.driverView1.DisplayClub = false;
            this.driverView1.DisplayTeam = false;
            this.driverView1.DisplayVehicle = false;
            this.driverView1.Location = new System.Drawing.Point(184, 1);
            this.driverView1.Name = "driverView1";
            this.driverView1.Size = new System.Drawing.Size(280, 26);
            this.driverView1.TabIndex = 6;
            // 
            // LeaderboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LeaderboardView";
            this.Size = new System.Drawing.Size(878, 32);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource leaderboardViewModelBindingSource;
        private System.Windows.Forms.Label positionLabel1;
        private System.Windows.Forms.Label carNumberLabel1;
        private System.Windows.Forms.Label intervalToNextLabel1;
        private DriverView driverView1;
        private System.Windows.Forms.Label lapTimeLabel1;
        private System.Windows.Forms.Label lapTimeDeltaLabel1;
        private System.Windows.Forms.Label lapMPHLabel1;
        private System.Windows.Forms.Label lapMPHDeltaLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label intervalLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}
