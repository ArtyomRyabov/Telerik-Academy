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
                this.AutoGrow();
            }

            this.genericList[this.nextAddIndex] = elementToAdd;
            this.nextAddIndex++;
        }

        public void RemoveElementAt(int index)
        {
            this.CheckIndexValidity(index);

            this.Capacity -= 1;
            T[] newGenericList = new T[this.Capacity];

            if (index > 0)
            {
                Array.Copy(this.genericList, 0, newGenericList, 0, index);
            }

            Array.Copy(this.genericList, index + 1, newGenericList, index, (this.genericList.Length - 1) - index);
            this.genericList = newGenericList;
            this.nextAddIndex--;
        }

        public void InsertElementAt(int index, T elementToInsert)
        {
            this.CheckIndexValidity(index);

            if (index == this.nextAddIndex)
            {
                this.AddElement(elementToInsert);
            }
            else
            {
                this.Capacity += 1;
                T[] newGenericList = new T[this.Capacity];

                if (index > 0)
                {
                    Array.Copy(this.genericList, 0, newGenericList, 0, index);
                }

                newGenericList[index] = elementToInsert;
                Array.Copy(this.genericList, index, newGenericList, index + 1, (this.genericList.Length - 1) - index);
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
            if (this.nextAddIndex == 0)
            {
                throw new ArgumentNullException("The list is empty");
            }

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
            if (this.nextAddIndex == 0)
            {
                throw new ArgumentNullException("The list is empty");
            }

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

        private void AutoGrow()                            // Problem 6
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
