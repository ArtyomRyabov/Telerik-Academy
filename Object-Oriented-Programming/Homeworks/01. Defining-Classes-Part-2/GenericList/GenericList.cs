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

        public GenericList(int StartCapacity)
        {
            this.Capacity = StartCapacity;
            this.genericList = new T[StartCapacity];
            this.nextAddIndex = 0;
        }

        public int Capacity { get; private set; }

        public T this[int index]
        {
            get
            {
                CheckIndexValidity(index);

                return this.genericList[index];
            }
        }

        public void AddElement(T elementToAdd)
        {
            if (nextAddIndex == genericList.Length)
            {
                DoubleArraySize();
            }

            this.genericList[nextAddIndex] = elementToAdd;
            nextAddIndex++;
        }

        public void RemoveElementAt(int removeIndex)
        {
            CheckIndexValidity(removeIndex);

            this.Capacity -= 1;
            T[] newGenericList = new T[this.Capacity];

            if (removeIndex > 0)
            {
                Array.Copy(genericList, 0, newGenericList, 0, removeIndex);
            }

            Array.Copy(genericList, removeIndex + 1, newGenericList, removeIndex, (genericList.Length - 1) - removeIndex);
            genericList = newGenericList;
            this.nextAddIndex--;
        }

        public void InsertElementAt(int insertIndex, T elementToInsert)
        {
            CheckIndexValidity(insertIndex);

            if (insertIndex == nextAddIndex)
            {
                AddElement(elementToInsert);
            }
            else
            {
                this.Capacity += 1;
                T[] newGenericList = new T[this.Capacity];

                if (insertIndex > 0)
                {
                    Array.Copy(genericList, 0, newGenericList, 0, insertIndex);
                }

                newGenericList[insertIndex] = elementToInsert;
                Array.Copy(genericList, insertIndex, newGenericList, insertIndex + 1, (genericList.Length - 1) - insertIndex);
                genericList = newGenericList;
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
            if (!genericList.Contains(element))
            {
                throw new ArgumentException("There is no such element!");
            }

            return Array.IndexOf(this.genericList, element);
        }

        public T Min()                                       // Problem 7
        {
            T min = genericList[0];

            for (int i = 1; i < nextAddIndex; i++)
            {
                if (genericList[i].CompareTo(min) < 0)
                {
                    min = genericList[i];
                }
            }

            return min;
        }

        public T Max()                                       // Problem 7
        {
            T max = genericList[0];

            for (int i = 1; i < nextAddIndex; i++)
            {
                if (genericList[i].CompareTo(max) > 0)
                {
                    max = genericList[i];
                }
            }

            return max;
        }

        private void DoubleArraySize()                            // Problem 6
        {
            this.Capacity *= 2;
            T[] newGenericList = new T[this.Capacity];
            Array.Copy(this.genericList, newGenericList, genericList.Length);
            this.genericList = newGenericList;
        }

        private void CheckIndexValidity(int index)
        {
            if (index < 0 || index >= genericList.Length)
            {
                throw new IndexOutOfRangeException(String.Format("Index {0} is out of range!", index));
            }
        }

        public override string ToString()
        {
            if (nextAddIndex == 0)
            {
                return "Zero contained elements";
            }

            StringBuilder output = new StringBuilder();

            output.AppendLine("Contained elements:");

            for (int i = 0; i < nextAddIndex; i++)
            {
                output.AppendLine(String.Format("{0} -> {1}", i, genericList[i]));
            }

            return output.ToString();
        }
    }
}
