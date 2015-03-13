namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private string model;                                // Problem 1
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iPhone4S;                         // Problem 6
        private List<Call> callHistory = new List<Call>();   // Problem 9

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

        static GSM()                          // Problem 6
        {
            IPhone4S = new GSM("iPhone 4s", "Apple", 500m, "Unknown", new Battery("Some Model", 200, 8, BatteryType.LiPo),
                       new Display(3.5, 16000000));
        }

        public static GSM IPhone4S            // Problem 6
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhone4S = value;
            }
        }

        public string Model                   // Problem 5
        {
            get
            {
                return this.model;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
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
                if (String.IsNullOrEmpty(value))
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
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid owner name!");
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

            info.Append(String.Format("Model: {0}\n", this.Model));
            info.Append(String.Format("Manufacturer: {0}\n", this.Manufacturer));
            info.Append(String.Format("Price: {0}\n", this.Price));
            info.Append(String.Format("Owner: {0}\n", this.Owner));
            info.Append(String.Format("Battery: {0}\n", this.battery.BatteryModel));
            info.Append(String.Format(" Type: {0}\n", this.battery.TypeBattery));
            info.Append(String.Format(" Idle Hours: {0}\n", this.battery.HoursIdle));
            info.Append(String.Format(" Talk Hours: {0}\n", this.battery.HoursTalk));
            info.Append("Diplay:\n");
            info.Append(String.Format(" Size: {0}\n", this.display.Size));
            info.Append(String.Format(" Number of Colours: {0}\n", this.display.Colours));

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

            foreach (Call call in callHistory)
            {
                totalDuration += call.Duration;
            }

            string price = String.Format("{0:C}", (totalDuration / 60m) * pricePerMinute);
            return price;
        }
    }
}
