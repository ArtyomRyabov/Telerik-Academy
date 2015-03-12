namespace MobilePhone
{
    using System;
    using System.Text;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iPhone4S;

        public GSM(string model, string manufacturer)
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

        public GSM()
        {
            IPhone4S = new GSM("iPhone 4s", "Apple", 500.00m, "Unknown", new Battery("Some Model", 200, 8, BatteryType.LiPo),
                       new Display(3.5, 16000000));
        }

        public static GSM IPhone4S
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

        public string Model
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

        public override string ToString()
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
    }
}
