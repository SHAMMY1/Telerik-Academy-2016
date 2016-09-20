using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class Extensions
    {
        public static T Min<T>(this GenericList<T> list) where T : IComparable
        {
            var min = list.Elements[0];

            for (int i = 1; i < list.LastIndex; i++)
            {
                if (min.CompareTo(list.Elements[i]) > 0)
                {
                    min = list.Elements[i];
                }
            }
            return min;
        }

        public static T Max<T>(this GenericList<T> list) where T : IComparable
        {
            var max = list.Elements[0];

            for (int i = 1; i < list.LastIndex; i++)
            {
                if (max.CompareTo(list.Elements[i]) < 0)
                {
                    max = list.Elements[i];
                }
            }
            return max;
        }
    }

    public class GenericList<T>
    {
        internal T[] Elements;
        internal int LastIndex;

        public GenericList(int size)
        {
            this.Elements = new T[size];
            LastIndex = 0;
        }

        public GenericList()
            : this(4)
        { }

        public void Add(T element)
        {
            if (LastIndex >= this.Elements.Length)
            {
                this.DoubleElementsLength();
            }

            Elements[LastIndex] = element;
            LastIndex++;
        }

        public T GetById(int id)
        {
            if (0 > id || id >= this.LastIndex)
            {
                throw new ArgumentOutOfRangeException("id", "index outside the bounds of the array");
            }

            return this.Elements[id];
        }

        public void RemoveById(int id)
        {
            if (0 > id || id >= this.LastIndex)
            {
                throw new ArgumentOutOfRangeException("id", "index outside the bounds of the array");
            }

            var newElements = new T[this.Elements.Length];

            for (int i = 0, j = 0; i < this.Elements.Length; i++, j++)
            {
                if (i == id)
                {
                    j--;
                }
                else
                {
                    newElements[j] = this.Elements[i];
                }
            }

            this.Elements = newElements;
            this.LastIndex--;
        }

        public void InsertAtId(T element, int id)
        {
            var newElements = new T[this.Elements.Length + 1];

            for (int i = 0, j = 0; i < this.Elements.Length; i++, j++)
            {
                if (i == id)
                {
                    newElements[j] = element;
                    i--;
                }
                else
                {
                    newElements[j] = this.Elements[i];
                }
            }

            this.Elements = newElements;
        }

        public void Clear()
        {
            this.Elements = new T[this.Elements.Length];
        }

        public int Find(T element)
        {
            for (int i = 0; i < LastIndex; i++)
            {
                if (this.Elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < LastIndex; i++)
            {
                result.Append(this.Elements[i]);

                if (i < LastIndex - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        private void DoubleElementsLength()
        {
            T[] newElements = new T[this.Elements.Length * 2];

            for (int i = 0; i < this.Elements.Length; i++)
            {
                newElements[i] = this.Elements[i];
            }

            this.Elements = newElements;
        }
    }
}
