namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using WarMachines.Common;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        protected Machine(string name, double healthPoints, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.Targets = new List<string>();
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                Validator.ChekIfStringIsNullOrEmty(value, "Machine name cannot be empty or null!");
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get { return this.pilot; }

            set
            {
                Validator.CheckIfNullObject(value, "Machine does not have engaged pilot yet.");
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get { return this.healthPoints; }

            set { this.healthPoints = value; }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }

            protected set { this.attackPoints = value; }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }

            protected set { this.defensePoints = value; }
        }

        public IList<string> Targets
        {
            get { return this.targets; }

            private set
            {
                Validator.CheckIfNullObject(value, "Not added targets yet.");
                this.targets = value;
            }
        }

        public void Attack(string target)
        {
            Validator.ChekIfStringIsNullOrEmty(target, "Target cannot be null!");
            this.Targets.Add(target);
        }

        public override string ToString()
        {
            var machineOutput = new StringBuilder();

            machineOutput.AppendLine(string.Format("- {0}", this.Name));
            machineOutput.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            machineOutput.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            machineOutput.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            machineOutput.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            machineOutput.AppendLine(string.Format(" *Targets: {0}", this.Targets.Count == 0 ? "None" : string.Join(", ", this.Targets)));

            return machineOutput.ToString();
        }
    }
}