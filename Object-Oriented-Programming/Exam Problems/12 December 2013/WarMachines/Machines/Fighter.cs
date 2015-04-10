namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;

    public class Fighter : Machine, IMachine, IFighter
    {
        private const double InitialHealthPoints = 200;

        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, InitialHealthPoints, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get { return this.stealthMode; }

            private set { this.stealthMode = value; }
        }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var fighterOutput = new StringBuilder();

            fighterOutput.Append(base.ToString());
            fighterOutput.Append(string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));

            return fighterOutput.ToString();
        }
    }
}