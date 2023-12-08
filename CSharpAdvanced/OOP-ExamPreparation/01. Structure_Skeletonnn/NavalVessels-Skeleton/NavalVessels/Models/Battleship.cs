using NavalVessels.Models.Contracts;
using System.Text;

namespace NavalVessels.Models
{
    public class Battleship : Vessel, IBattleship
    {
        private const double InitialArmorThickness = 300;
        public Battleship(string name, double mainWeaponCaliber, double speed, double armorThickness)
            : base(name, mainWeaponCaliber, speed, armorThickness)
        {
            SonarMode = false;
        }

        public bool SonarMode { get; private set; }

        public override void RepairVessel()
        {
            ArmorThickness = InitialArmorThickness;
        }

        public void ToggleSonarMode()
        {
            if (!SonarMode)
            {
                MainWeaponCaliber += 40;
                Speed -= 5;
            }
            else
            {
                MainWeaponCaliber -= 40;
                Speed += 5;
            }

            this.SonarMode = !this.SonarMode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string onOff = SonarMode ? "ON" : "OFF";

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Sonar mode: {onOff}");

            return sb.ToString().Trim();
        }
    }
}
