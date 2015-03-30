namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public byte this[int index]
        {
            get
            {
                if (index < 0 || index >= 64)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range [0 - 63]");
                }

                return (byte)((this.number >> index) & 1);
            }
            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range [0 - 63]");
                }

                if (value == 0)
                {
                    this.number &= (~((ulong)1 << index));
                }
                else if (value == 1)
                {
                    this.number |= ((ulong)1 << index);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Bit must be 0 or 1");
                }
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray.Equals(first, second);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int index = 0; index < 64; index++)
            {
                yield return this[index];
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + this.Number.GetHashCode();
        }
         
        public override bool Equals(object obj)
        {
            BitArray64 another = obj as BitArray64;

            if (another == null)
            {
                return false;
            }

            return this.Number.Equals(another.Number);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 63; i >= 0; i--)
            {
                result.Append((this.Number >> i) & 1);

                if (i % 4 == 0 && i != 0)
                {
                    result.Append(' ');
                }
            }

            return result.ToString();
        }

    }
}
