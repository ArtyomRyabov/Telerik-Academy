namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Common;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.Machines = new List<IMachine>();
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                Validator.ChekIfStringIsNullOrEmty(value, "Pilot name cannot be empty or null!");
                this.name = value;
            }
        }

        public IList<IMachine> Machines
        {
            get { return this.machines; }

            private set
            {
                Validator.CheckIfNullObject(value, "Machines' list is still empty.");
                this.machines = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.CheckIfNullObject(machine, "Machine to add cannot be null!");
            this.Machines.Add(machine);
        }

        public string Report()
        {
            var reportOutput = new StringBuilder();

            reportOutput.AppendLine(string.Format("{0} - {1} {2}", 
                                    this.Name, 
                                    this.Machines.Count > 0 ? this.Machines.Count.ToString() : "no",
                                    this.Machines.Count == 1 ? "machine" : "machines"));

            var sortedMachines = this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);

            foreach (var machine in sortedMachines)
            {
                reportOutput.AppendLine(machine.ToString());
            }

            return reportOutput.ToString().TrimEnd();
        }
    }
}
