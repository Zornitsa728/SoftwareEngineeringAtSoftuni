using NavalVessels.Models.Contracts;
using System.Text;

namespace NavalVessels.Models
{
    public class Submarine : Vessel, ISubmarine
    {
        private const double InitialArmorThickness = 200;
        public Submarine(string name, double mainWeaponCaliber, double speed, double armorThickness)
            : base(name, mainWeaponCaliber, speed, armorThickness)
        {
            SubmergeMode = false;
        }

        public bool SubmergeMode { get; private set; }

        public override void RepairVessel()
        {
            ArmorThickness = InitialArmorThickness;
        }

        public void ToggleSubmergeMode()
        {
            if (!SubmergeMode)
            {
                MainWeaponCaliber += 40;
                Speed -= 4;
            }
            else
            {
                MainWeaponCaliber -= 40;
                Speed += 4;
            }

            this.SubmergeMode = !this.SubmergeMode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string onOff = SubmergeMode ? "ON" : "OFF";

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Submerge mode: {onOff}");

            return sb.ToString().Trim();
        }
    }
}

