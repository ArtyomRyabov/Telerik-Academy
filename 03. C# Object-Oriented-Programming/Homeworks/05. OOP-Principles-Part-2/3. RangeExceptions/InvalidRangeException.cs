namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable<T>
    {
        public InvalidRangeException(T start, T end)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; private set; }

        public T End { get; private set; }

        public override string Message
        {
            get
            {
                return string.Format("Value is out of the allowed range [{0} - {1}]", this.Start, this.End);
            }
        }
    }
}
