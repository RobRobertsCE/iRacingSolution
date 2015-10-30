using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingCrewChief.Controls.ViewModels
{
    public class DriverViewModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Club { get; set; }
        public string Team { get; set; }
        public string Class { get; set; }
        Color _classColor = Color.White;
        public Color ClassColor
        {
            get
            {
                return _classColor;
            }
            set
            {
                _classColor = value;
            }
        }
        public string Vehicle { get; set; }
        public string LicenseLevel { get; set; }
        public Single SR { get; set; }
        public int iRating { get; set; }
        public Color LicenseColor
        {
            get
            {
                if (String.IsNullOrEmpty(LicenseLevel))
                {
                    return Color.White;
                }
                else
                {
                    switch (LicenseLevel)
                    {
                        case "R":
                            {
                                return Color.Red;
                            }
                        case "D":
                            {
                                return Color.Orange;
                            }
                        case "C":
                            {
                                return Color.Yellow;
                            }
                        case "B":
                            {
                                return Color.Green;
                            }
                        case "A":
                            {
                                return Color.Blue;
                            }
                        case "P":
                            {
                                return Color.Black;
                            }
                        default:
                            {
                                return Color.White;
                            }
                    }
                }
            }
        }
        public string DriverLicenseInfo
        {
            get
            {
                return String.Format("{0} {1:0.00} / {2:###0}", LicenseLevel, SR, iRating);
            }
        }
    }
}
