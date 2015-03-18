namespace GenericList
{
    using System;
    using System.Linq;
    using System.Text;

    public class GenericList<T>                         // Problem 5
       where T : IComparable
    {
        private const int StartCapacity = 4;

        private T[] genericList;
        private int nextAddIndex;

        public GenericList()
        {
            this.Capacity = StartCapacity;
            this.genericList = new T[this.Capacity];
            this.nextAddIndex = 0;
        }

        public int Capacity { get; private set; }

        public T this[int index]
        {
            get
            {
                this.CheckIndexValidity(index);

                return this.genericList[index];
            }
        }

        public void AddElement(T elementToAdd)
        {
            if (this.nextAddIndex == this.genericList.Length)
            {
                this.DoubleArraySize();
            }

            this.genericList[this.nextAddIndex] = elementToAdd;
            this.nextAddIndex++;
        }

        public void RemoveElementAt(int removeIndex)
        {
            this.CheckIndexValidity(removeIndex);

            this.Capacity -= 1;
            T[] newGenericList = new T[this.Capacity];

            if (removeIndex > 0)
            {
                Array.Copy(this.genericList, 0, newGenericList, 0, removeIndex);
            }

            Array.Copy(this.genericList, removeIndex + 1, newGenericList, removeIndex, (this.genericList.Length - 1) - removeIndex);
            this.genericList = newGenericList;
            this.nextAddIndex--;
        }

        public void InsertElementAt(int insertIndex, T elementToInsert)
        {
            this.CheckIndexValidity(insertIndex);

            if (insertIndex == this.nextAddIndex)
            {
                this.AddElement(elementToInsert);
            }
            else
            {
                this.Capacity += 1;
                T[] newGenericList = new T[this.Capacity];

                if (insertIndex > 0)
                {
                    Array.Copy(this.genericList, 0, newGenericList, 0, insertIndex);
                }

                newGenericList[insertIndex] = elementToInsert;
                Array.Copy(this.genericList, insertIndex, newGenericList, insertIndex + 1, (this.genericList.Length - 1) - insertIndex);
                this.genericList = newGenericList;
                this.nextAddIndex++;
            }
        }

        public void ClearGenericList()
        {
            this.Capacity = StartCapacity;
            this.genericList = new T[StartCapacity];
            this.nextAddIndex = 0;
        }

        public int FindElement(T element)
        {
            if (!this.genericList.Contains(element))
            {
                throw new ArgumentException("There is no such element!");
            }

            return Array.IndexOf(this.genericList, element);
        }

        public T Min()                                       // Problem 7
        {
            T min = this.genericList[0];

            for (int i = 1; i < this.nextAddIndex; i++)
            {
                if (this.genericList[i].CompareTo(min) < 0)
                {
                    min = this.genericList[i];
                }
            }

            return min;
        }

        public T Max()                                       // Problem 7
        {
            T max = this.genericList[0];

            for (int i = 1; i < this.nextAddIndex; i++)
            {
                if (this.genericList[i].CompareTo(max) > 0)
                {
                    max = this.genericList[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            if (this.nextAddIndex == 0)
            {
                return "Zero contained elements";
            }

            StringBuilder output = new StringBuilder();

            output.AppendLine("Contained elements:");

            for (int i = 0; i < this.nextAddIndex; i++)
            {
                output.AppendLine(string.Format("{0} -> {1}", i, this.genericList[i]));
            }

            return output.ToString();
        }

        private void DoubleArraySize()                            // Problem 6
        {
            this.Capacity *= 2;
            T[] newGenericList = new T[this.Capacity];
            Array.Copy(this.genericList, newGenericList, this.genericList.Length);
            this.genericList = newGenericList;
        }

        private void CheckIndexValidity(int index)
        {
            if (index < 0 || index >= this.genericList.Length)
            {
                throw new IndexOutOfRangeException(string.Format("Index {0} is out of range!", index));
            }
        }
    }
}
