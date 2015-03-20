namespace TimerProblem
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate();

    public class Timer
    {
        private int counter;
        private int interval;

        public Timer(int interval, int counter)
        {
            this.Interval = interval;
            this.Counter = counter;
        }

        public int Interval
        {
            get
            {
                return this.interval;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Interval must be positive number");
                }

                this.interval = value;
            }
        }

        public int Counter
        {
            get
            {
                return this.counter;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Counter must be positive number");
                }

                this.counter = value;
            }
        }

        public TimerDelegate TDelegate { get; set; }

        public void Execute()
        {
            while (this.counter > 0)
            {
                Thread.Sleep(this.Interval);
                counter--;
                this.TDelegate();
            }
        }
    }
}
