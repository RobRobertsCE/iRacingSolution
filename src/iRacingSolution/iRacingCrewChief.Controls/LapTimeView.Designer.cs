namespace iRacingCrewChief.Controls
{
    partial class LapTimeView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lapNumberLabel1 = new System.Windows.Forms.Label();
            this.lapTimeLabel1 = new System.Windows.Forms.Label();
            this.lapTimeDeltaLabel1 = new System.Windows.Forms.Label();
            this.lapMPHLabel1 = new System.Windows.Forms.Label();
            this.lapMPHDeltaLabel1 = new System.Windows.Forms.Label();
            this.lapTimeViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intervalLabel1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lapTimeViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lapNumberLabel1);
            this.flowLayoutPanel1.Controls.Add(this.lapTimeLabel1);
            this.flowLayoutPanel1.Controls.Add(this.lapTimeDeltaLabel1);
            this.flowLayoutPanel1.Controls.Add(this.lapMPHLabel1);
            this.flowLayoutPanel1.Controls.Add(this.lapMPHDeltaLabel1);
            this.flowLayoutPanel1.Controls.Add(this.intervalLabel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(588, 25);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lapNumberLabel1
            // 
            this.lapNumberLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lapNumberLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lapTimeViewModelBindingSource, "LapNumber", true));
            this.lapNumberLabel1.Location = new System.Drawing.Point(3, 0);
            this.lapNumberLabel1.Name = "lapNumberLabel1";
            this.lapNumberLabel1.Size = new System.Drawing.Size(52, 23);
            this.lapNumberLabel1.TabIndex = 3;
            this.lapNumberLabel1.Text = "[Lap#]";
            this.lapNumberLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lapTimeLabel1
            // 
            this.lapTimeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lapTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lapTimeViewModelBindingSource, "LapTime", true));
            this.lapTimeLabel1.Location = new System.Drawing.Point(61, 0);
            this.lapTimeLabel1.Name = "lapTimeLabel1";
            this.lapTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.lapTimeLabel1.TabIndex = 4;
            this.lapTimeLabel1.Text = "[LapTime]";
            this.lapTimeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lapTimeDeltaLabel1
            // 
            this.lapTimeDeltaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lapTimeDeltaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lapTimeViewModelBindingSource, "LapTimeDelta", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.lapTimeDeltaLabel1.Location = new System.Drawing.Point(167, 0);
            this.lapTimeDeltaLabel1.Name = "lapTimeDeltaLabel1";
            this.lapTimeDeltaLabel1.Size = new System.Drawing.Size(100, 23);
            this.lapTimeDeltaLabel1.TabIndex = 6;
            this.lapTimeDeltaLabel1.Text = "[LapTimeDelta]";
            this.lapTimeDeltaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lapMPHLabel1
            // 
            this.lapMPHLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lapMPHLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lapTimeViewModelBindingSource, "LapMPH", true));
            this.lapMPHLabel1.Location = new System.Drawing.Point(273, 0);
            this.lapMPHLabel1.Name = "lapMPHLabel1";
            this.lapMPHLabel1.Size = new System.Drawing.Size(100, 23);
            this.lapMPHLabel1.TabIndex = 8;
            this.lapMPHLabel1.Text = "[LapMPH]";
            this.lapMPHLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lapMPHDeltaLabel1
            // 
            this.lapMPHDeltaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lapMPHDeltaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lapTimeViewModelBindingSource, "LapMPHDelta", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.lapMPHDeltaLabel1.Location = new System.Drawing.Point(379, 0);
            this.lapMPHDeltaLabel1.Name = "lapMPHDeltaLabel1";
            this.lapMPHDeltaLabel1.Size = new System.Drawing.Size(100, 23);
            this.lapMPHDeltaLabel1.TabIndex = 10;
            this.lapMPHDeltaLabel1.Text = "[LapMPHDelta]";
            this.lapMPHDeltaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lapTimeViewModelBindingSource
            // 
            this.lapTimeViewModelBindingSource.DataSource = typeof(iRacingCrewChief.Controls.ViewModels.LapTimeViewModel);
            // 
            // intervalLabel1
            // 
            this.intervalLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intervalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lapTimeViewModelBindingSource, "Interval", true));
            this.intervalLabel1.Location = new System.Drawing.Point(485, 0);
            this.intervalLabel1.Name = "intervalLabel1";
            this.intervalLabel1.Size = new System.Drawing.Size(100, 23);
            this.intervalLabel1.TabIndex = 11;
            this.intervalLabel1.Text = "[interval]";
            this.intervalLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LapTimeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "LapTimeView";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(594, 31);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lapTimeViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lapNumberLabel1;
        private System.Windows.Forms.BindingSource lapTimeViewModelBindingSource;
        private System.Windows.Forms.Label lapTimeLabel1;
        private System.Windows.Forms.Label lapTimeDeltaLabel1;
        private System.Windows.Forms.Label lapMPHLabel1;
        private System.Windows.Forms.Label lapMPHDeltaLabel1;
        private System.Windows.Forms.Label intervalLabel1;
    }
}
