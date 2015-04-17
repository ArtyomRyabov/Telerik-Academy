namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;

    public class Tank : Machine, IMachine, ITank
    {
        private const double InitialHealthPoints = 100;
        private const double DefencePointsChange = 30;
        private const double AttackPointsChange = 40;

        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, InitialHealthPoints, attackPoints, defensePoints)
        {
            this.DefenseMode = true;
            this.DefensePoints += DefencePointsChange;
            this.AttackPoints -= AttackPointsChange;
        }

        public bool DefenseMode
        {
            get { return this.defenseMode; }

            private set { this.defenseMode = value; }
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefenseMode = false;
                this.DefensePoints -= DefencePointsChange;
                this.AttackPoints += AttackPointsChange;
            }
            else
            {
                this.DefenseMode = true;
                this.DefensePoints += DefencePointsChange;
                this.AttackPoints -= AttackPointsChange;
            }
        }

        public override string ToString()
        {
            var tankOutput = new StringBuilder();

            tankOutput.Append(base.ToString());
            tankOutput.Append(string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF"));

            return tankOutput.ToString();
        }
    }
}