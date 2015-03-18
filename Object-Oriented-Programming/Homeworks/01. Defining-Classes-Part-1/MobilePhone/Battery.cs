namespace MobilePhone
{
    using System;

    public enum BatteryType                 // Problem 3
    { 
        LiIon, 
        LiPo, 
        NiMH, 
        NiCd 
    }   

    public class Battery
    {
        private string batteryModel;      // Problem 1
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType typeBattery;

        public Battery()                  // Problem 2
            : this(null)
        {
        }
        
        public Battery(string batteryModel)
            : this(batteryModel, null)
        {
        }

        public Battery(string batteryModel, double? hoursIdle)
            : this(batteryModel, hoursIdle, null)
        {
        }

        public Battery(string batteryModel, double? hoursIdle, double? hoursTalk)
            : this(batteryModel, hoursIdle, hoursTalk, new BatteryType())
        {
        }

        public Battery(string batteryModel, double? hoursIdle, double? hoursTalk, BatteryType typeBattery)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.TypeBattery = typeBattery;
        }

        public string BatteryModel                   // Problem 5
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    value = "Unknown";
                }

                this.batteryModel = value;
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid idle hours!");
                }

                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid talk hours!");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType TypeBattery
        {
            get
            {
                return this.typeBattery;
            }
            set
            {
                this.typeBattery = value;
            }
        }
    }
}
