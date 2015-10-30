namespace iRacingCrewChief.Controls
{
    partial class DriverView
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
            this.picLicense = new System.Windows.Forms.PictureBox();
            this.driverViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.vehicleLabel1 = new System.Windows.Forms.Label();
            this.teamLabel1 = new System.Windows.Forms.Label();
            this.clubLabel1 = new System.Windows.Forms.Label();
            this.driverToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverViewModelBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLicense
            // 
            this.picLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLicense.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.driverViewModelBindingSource, "LicenseColor", true));
            this.picLicense.Location = new System.Drawing.Point(3, 3);
            this.picLicense.Name = "picLicense";
            this.picLicense.Size = new System.Drawing.Size(32, 23);
            this.picLicense.TabIndex = 3;
            this.picLicense.TabStop = false;
            // 
            // driverViewModelBindingSource
            // 
            this.driverViewModelBindingSource.DataSource = typeof(iRacingCrewChief.Controls.ViewModels.DriverViewModel);
            // 
            // nameLabel1
            // 
            this.nameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverViewModelBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(40, 3);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(232, 23);
            this.nameLabel1.TabIndex = 4;
            this.nameLabel1.Text = "label1";
            this.nameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.vehicleLabel1);
            this.flowLayoutPanel1.Controls.Add(this.teamLabel1);
            this.flowLayoutPanel1.Controls.Add(this.clubLabel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(280, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(537, 31);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // vehicleLabel1
            // 
            this.vehicleLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverViewModelBindingSource, "Vehicle", true));
            this.vehicleLabel1.Location = new System.Drawing.Point(6, 3);
            this.vehicleLabel1.Name = "vehicleLabel1";
            this.vehicleLabel1.Size = new System.Drawing.Size(173, 23);
            this.vehicleLabel1.TabIndex = 6;
            this.vehicleLabel1.Text = "[vehicle]";
            this.vehicleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamLabel1
            // 
            this.teamLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverViewModelBindingSource, "Team", true));
            this.teamLabel1.Location = new System.Drawing.Point(185, 3);
            this.teamLabel1.Name = "teamLabel1";
            this.teamLabel1.Size = new System.Drawing.Size(170, 23);
            this.teamLabel1.TabIndex = 7;
            this.teamLabel1.Text = "[team]";
            this.teamLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clubLabel1
            // 
            this.clubLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clubLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverViewModelBindingSource, "Club", true));
            this.clubLabel1.Location = new System.Drawing.Point(361, 3);
            this.clubLabel1.Name = "clubLabel1";
            this.clubLabel1.Size = new System.Drawing.Size(170, 23);
            this.clubLabel1.TabIndex = 6;
            this.clubLabel1.Text = "[club]";
            this.clubLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picLicense);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 31);
            this.panel1.TabIndex = 6;
            // 
            // DriverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "DriverView";
            this.Size = new System.Drawing.Size(817, 31);
            ((System.ComponentModel.ISupportInitialize)(this.picLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverViewModelBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource driverViewModelBindingSource;
        private System.Windows.Forms.PictureBox picLicense;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label vehicleLabel1;
        private System.Windows.Forms.Label teamLabel1;
        private System.Windows.Forms.Label clubLabel1;
        private System.Windows.Forms.ToolTip driverToolTip;
        private System.Windows.Forms.Panel panel1;
    }
}
