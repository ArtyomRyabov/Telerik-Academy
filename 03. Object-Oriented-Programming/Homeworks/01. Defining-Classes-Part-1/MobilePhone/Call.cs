namespace MobilePhone
{
    using System;

    public class Call                             // Problem 8
    {
        private DateTime dateTime;
        private string dialedNumber;
        private uint duration;

        public Call(DateTime dateTime, string dialedNumber, uint duration)
        {
            this.DateTime = dateTime;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                this.dateTime = value;
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            set
            {
                this.dialedNumber = value;
            }
        }

        public uint Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Dialed number: {0} / Duration: {1} sec. / {2}", this.DialedNumber, this.Duration, this.DateTime);
        }
    }
}
