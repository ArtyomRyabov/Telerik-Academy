namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {                                                   // Problem 6
        private static GSM iPhone4S = new GSM(
            "iPhone 4s", "Apple", 500m, "", new Battery("", 200, 8, BatteryType.LiPo), new Display(3.5, 16000000));                         

        private string model;                                // Problem 1
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;

        private List<Call> callHistory = new List<Call>();    // Problem 9

        public GSM()                                          // Problem 2
        {
        }

        public GSM(string model, string manufacturer)         // Problem 2
            : this(model, manufacturer, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, new Battery())
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, new Display())
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public static GSM IPhone4S                 // Problem 6
        {
            get
            {
                return iPhone4S;
            }
        }

        public string Model                        // Problem 5
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid model!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid manufacturer!");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    value = "Unknown";
                }

                this.owner = value;
            }
        }

        public List<Call> CallHistory                       // Problem 9
        {
            get
            {
                return this.callHistory;
            }
        }

        public override string ToString()                   // Problem 4
        {
            StringBuilder info = new StringBuilder();

            info.Append(string.Format("Model: {0}\n", this.Model));
            info.Append(string.Format("Manufacturer: {0}\n", this.Manufacturer));
            info.Append(string.Format("Price: {0}\n", this.Price));
            info.Append(string.Format("Owner: {0}\n", this.Owner));
            info.Append(string.Format("Battery: {0}\n", this.battery.BatteryModel));
            info.Append(string.Format(" Type: {0}\n", this.battery.TypeBattery));
            info.Append(string.Format(" Idle Hours: {0}\n", this.battery.HoursIdle));
            info.Append(string.Format(" Talk Hours: {0}\n", this.battery.HoursTalk));
            info.Append("Diplay:\n");
            info.Append(string.Format(" Size: {0}\n", this.display.Size));
            info.Append(string.Format(" Number of Colours: {0}\n", this.display.Colours));

            return info.ToString();
        }

        public void AddCall(Call newCall)                   // Problem 10
        {
            this.callHistory.Add(newCall);
        }

        public void RemoveCall(Call removeCall)
        {
            this.callHistory.Remove(removeCall);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public string CallsTotalPrice(decimal pricePerMinute)     // Problem 11
        {
            uint totalDuration = 0;

            foreach (Call call in this.callHistory)
            {
                totalDuration += call.Duration;
            }

            string price = string.Format("{0:C}", (totalDuration / 60m) * pricePerMinute);
            return price;
        }
    }
}
