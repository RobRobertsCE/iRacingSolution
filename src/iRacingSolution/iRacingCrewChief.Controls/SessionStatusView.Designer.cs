namespace iRacingCrewChief.Controls
{
    partial class SessionStatusView
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
            System.Windows.Forms.Label trackNameLabel;
            System.Windows.Forms.Label trackLengthLabel;
            System.Windows.Forms.Label sessionNameLabel;
            System.Windows.Forms.Label sessionStateLabel;
            System.Windows.Forms.Label driverNameLabel;
            System.Windows.Forms.Label vehicleDescriptionLabel;
            System.Windows.Forms.Label weatherSummaryLabel;
            this.trackNameTextBox = new System.Windows.Forms.TextBox();
            this.trackLengthTextBox = new System.Windows.Forms.TextBox();
            this.sessionNameTextBox = new System.Windows.Forms.TextBox();
            this.sessionStateTextBox = new System.Windows.Forms.TextBox();
            this.driverNameTextBox = new System.Windows.Forms.TextBox();
            this.vehicleDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.weatherSummaryTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTimedSession = new System.Windows.Forms.Panel();
            this.pnlLapLimitSession = new System.Windows.Forms.Panel();
            this.sessionElapsedTimeTextBox = new System.Windows.Forms.TextBox();
            this.currentLapNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sessionStateViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            trackNameLabel = new System.Windows.Forms.Label();
            trackLengthLabel = new System.Windows.Forms.Label();
            sessionNameLabel = new System.Windows.Forms.Label();
            sessionStateLabel = new System.Windows.Forms.Label();
            driverNameLabel = new System.Windows.Forms.Label();
            vehicleDescriptionLabel = new System.Windows.Forms.Label();
            weatherSummaryLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlTimedSession.SuspendLayout();
            this.pnlLapLimitSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionStateViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trackNameLabel
            // 
            trackNameLabel.AutoSize = true;
            trackNameLabel.Location = new System.Drawing.Point(16, 8);
            trackNameLabel.Name = "trackNameLabel";
            trackNameLabel.Size = new System.Drawing.Size(69, 13);
            trackNameLabel.TabIndex = 1;
            trackNameLabel.Text = "Track Name:";
            // 
            // trackNameTextBox
            // 
            this.trackNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionStateViewModelBindingSource, "TrackName", true));
            this.trackNameTextBox.Location = new System.Drawing.Point(96, 8);
            this.trackNameTextBox.Name = "trackNameTextBox";
            this.trackNameTextBox.Size = new System.Drawing.Size(216, 20);
            this.trackNameTextBox.TabIndex = 2;
            // 
            // trackLengthLabel
            // 
            trackLengthLabel.AutoSize = true;
            trackLengthLabel.Location = new System.Drawing.Point(320, 8);
            trackLengthLabel.Name = "trackLengthLabel";
            trackLengthLabel.Size = new System.Drawing.Size(74, 13);
            trackLengthLabel.TabIndex = 2;
            trackLengthLabel.Text = "Track Length:";
            // 
            // trackLengthTextBox
            // 
            this.trackLengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionStateViewModelBindingSource, "TrackLength", true));
            this.trackLengthTextBox.Location = new System.Drawing.Point(400, 8);
            this.trackLengthTextBox.Name = "trackLengthTextBox";
            this.trackLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.trackLengthTextBox.TabIndex = 3;
            // 
            // sessionNameLabel
            // 
            sessionNameLabel.AutoSize = true;
            sessionNameLabel.Location = new System.Drawing.Point(8, 32);
            sessionNameLabel.Name = "sessionNameLabel";
            sessionNameLabel.Size = new System.Drawing.Size(78, 13);
            sessionNameLabel.TabIndex = 4;
            sessionNameLabel.Text = "Session Name:";
            // 
            // sessionNameTextBox
            // 
            this.sessionNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionStateViewModelBindingSource, "SessionName", true));
            this.sessionNameTextBox.Location = new System.Drawing.Point(96, 32);
            this.sessionNameTextBox.Name = "sessionNameTextBox";
            this.sessionNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.sessionNameTextBox.TabIndex = 5;
            // 
            // sessionStateLabel
            // 
            sessionStateLabel.AutoSize = true;
            sessionStateLabel.Location = new System.Drawing.Point(320, 32);
            sessionStateLabel.Name = "sessionStateLabel";
            sessionStateLabel.Size = new System.Drawing.Size(75, 13);
            sessionStateLabel.TabIndex = 6;
            sessionStateLabel.Text = "Session State:";
            // 
            // sessionStateTextBox
            // 
            this.sessionStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionStateViewModelBindingSource, "SessionState", true));
            this.sessionStateTextBox.Location = new System.Drawing.Point(400, 32);
            this.sessionStateTextBox.Name = "sessionStateTextBox";
            this.sessionStateTextBox.Size = new System.Drawing.Size(100, 20);
            this.sessionStateTextBox.TabIndex = 7;
            // 
            // driverNameLabel
            // 
            driverNameLabel.AutoSize = true;
            driverNameLabel.Location = new System.Drawing.Point(16, 56);
            driverNameLabel.Name = "driverNameLabel";
            driverNameLabel.Size = new System.Drawing.Size(69, 13);
            driverNameLabel.TabIndex = 8;
            driverNameLabel.Text = "Driver Name:";
            // 
            // driverNameTextBox
            // 
            this.driverNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionStateViewModelBindingSource, "DriverName", true));
            this.driverNameTextBox.Location = new System.Drawing.Point(96, 56);
            this.driverNameTextBox.Name = "driverNameTextBox";
            this.driverNameTextBox.Size = new System.Drawing.Size(216, 20);
            this.driverNameTextBox.TabIndex = 9;
            // 
            // vehicleDescriptionLabel
            // 
            vehicleDescriptionLabel.AutoSize = true;
            vehicleDescriptionLabel.Location = new System.Drawing.Point(344, 56);
            vehicleDescriptionLabel.Name = "vehicleDescriptionLabel";
            vehicleDescriptionLabel.Size = new System.Drawing.Size(42, 13);
            vehicleDescriptionLabel.TabIndex = 10;
            vehicleDescriptionLabel.Text = "Vehicle";
            // 
            // vehicleDescriptionTextBox
            // 
            this.vehicleDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionStateViewModelBindingSource, "VehicleDescription", true));
            this.vehicleDescriptionTextBox.Location = new System.Drawing.Point(400, 56);
            this.vehicleDescriptionTextBox.Name = "vehicleDescriptionTextBox";
            this.vehicleDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleDescriptionTextBox.TabIndex = 11;
            // 
            // weatherSummaryLabel
            // 
            weatherSummaryLabel.AutoSize = true;
            weatherSummaryLabel.Location = new System.Drawing.Point(544, 8);
            weatherSummaryLabel.Name = "weatherSummaryLabel";
            weatherSummaryLabel.Size = new System.Drawing.Size(48, 13);
            weatherSummaryLabel.TabIndex = 14;
            weatherSummaryLabel.Text = "Weather";
            // 
            // weatherSummaryTextBox
            // 
            this.weatherSummaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionStateViewModelBindingSource, "WeatherSummary", true));
            this.weatherSummaryTextBox.Location = new System.Drawing.Point(608, 8);
            this.weatherSummaryTextBox.Name = "weatherSummaryTextBox";
            this.weatherSummaryTextBox.Size = new System.Drawing.Size(192, 20);
            this.weatherSummaryTextBox.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlTimedSession);
            this.flowLayoutPanel1.Controls.Add(this.pnlLapLimitSession);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(520, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 32);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // pnlTimedSession
            // 
            this.pnlTimedSession.Controls.Add(this.label1);
            this.pnlTimedSession.Controls.Add(this.sessionElapsedTimeTextBox);
            this.pnlTimedSession.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.sessionStateViewModelBindingSource, "IsTimedSession", true));
            this.pnlTimedSession.Location = new System.Drawing.Point(3, 3);
            this.pnlTimedSession.Name = "pnlTimedSession";
            this.pnlTimedSession.Size = new System.Drawing.Size(229, 21);
            this.pnlTimedSession.TabIndex = 0;
            // 
            // pnlLapLimitSession
            // 
            this.pnlLapLimitSession.Controls.Add(this.label2);
            this.pnlLapLimitSession.Controls.Add(this.currentLapNumberTextBox);
            this.pnlLapLimitSession.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.sessionStateViewModelBindingSource, "IsLapLimitedSession", true));
            this.pnlLapLimitSession.Location = new System.Drawing.Point(3, 30);
            this.pnlLapLimitSession.Name = "pnlLapLimitSession";
            this.pnlLapLimitSession.Size = new System.Drawing.Size(229, 21);
            this.pnlLapLimitSession.TabIndex = 1;
            // 
            // sessionElapsedTimeTextBox
            // 
            this.sessionElapsedTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionStateViewModelBindingSource, "SessionTimeRemaining", true));
            this.sessionElapsedTimeTextBox.Location = new System.Drawing.Point(88, 0);
            this.sessionElapsedTimeTextBox.Name = "sessionElapsedTimeTextBox";
            this.sessionElapsedTimeTextBox.Size = new System.Drawing.Size(128, 20);
            this.sessionElapsedTimeTextBox.TabIndex = 1;
            // 
            // currentLapNumberTextBox
            // 
            this.currentLapNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionStateViewModelBindingSource, "LapsRemainingCaption", true));
            this.currentLapNumberTextBox.Location = new System.Drawing.Point(88, 0);
            this.currentLapNumberTextBox.Name = "currentLapNumberTextBox";
            this.currentLapNumberTextBox.Size = new System.Drawing.Size(128, 20);
            this.currentLapNumberTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Laps:";
            // 
            // sessionStateViewModelBindingSource
            // 
            this.sessionStateViewModelBindingSource.DataSource = typeof(iRacingCrewChief.Controls.ViewModels.SessionStateViewModel);
            // 
            // SessionStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(weatherSummaryLabel);
            this.Controls.Add(this.weatherSummaryTextBox);
            this.Controls.Add(vehicleDescriptionLabel);
            this.Controls.Add(this.vehicleDescriptionTextBox);
            this.Controls.Add(driverNameLabel);
            this.Controls.Add(this.driverNameTextBox);
            this.Controls.Add(sessionStateLabel);
            this.Controls.Add(this.sessionStateTextBox);
            this.Controls.Add(sessionNameLabel);
            this.Controls.Add(this.sessionNameTextBox);
            this.Controls.Add(trackLengthLabel);
            this.Controls.Add(this.trackLengthTextBox);
            this.Controls.Add(trackNameLabel);
            this.Controls.Add(this.trackNameTextBox);
            this.Name = "SessionStatus";
            this.Size = new System.Drawing.Size(830, 86);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlTimedSession.ResumeLayout(false);
            this.pnlTimedSession.PerformLayout();
            this.pnlLapLimitSession.ResumeLayout(false);
            this.pnlLapLimitSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionStateViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sessionStateViewModelBindingSource;
        private System.Windows.Forms.TextBox trackNameTextBox;
        private System.Windows.Forms.TextBox trackLengthTextBox;
        private System.Windows.Forms.TextBox sessionNameTextBox;
        private System.Windows.Forms.TextBox sessionStateTextBox;
        private System.Windows.Forms.TextBox driverNameTextBox;
        private System.Windows.Forms.TextBox vehicleDescriptionTextBox;
        private System.Windows.Forms.TextBox weatherSummaryTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlTimedSession;
        private System.Windows.Forms.Panel pnlLapLimitSession;
        private System.Windows.Forms.TextBox sessionElapsedTimeTextBox;
        private System.Windows.Forms.TextBox currentLapNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
