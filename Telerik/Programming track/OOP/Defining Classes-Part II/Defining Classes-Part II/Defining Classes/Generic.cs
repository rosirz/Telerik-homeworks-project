using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    class GenericList<T> where T : IComparable <T>
    {
        private T[] elements;
        private const int StartingCapacity = 4; //starting fixed capacity

        public int Capacity { get { return elements.Length; } }
        public int Count { get; set; }
        public T this[int index]  {
            get {return this.elements[index] ; }
            set {this.elements[index]=value; }
        }

        public GenericList ()
            {
            this.Count = 0;
            this.elements = new T[StartingCapacity];
            }

        //adding element, accessing element by index, removing element by index, inserting element at given position, 
        //clearing the list, finding element by its value and ToString().

        public T Access (int index) //accessing element by index
        {

            return this.elements[index];
        }

        public void Add (T item) //adding element
        {
            if (this.Count==this.Capacity)
            {
                this.AutoGrow();
            }
            elements[this.Count++] = item;
        }

        public void Remove (int index) //removing element by index
        {
            for (int i = index; i < this.Count-1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[this.Count - 1] = default(T);
            this.Count--;
        }

        public void Insert (int index, T item) //inserting element at given position
        {
            this.Count++;
            if (this.Count >= this.Capacity)
            {
                this.AutoGrow();
            }
            for (int i = this.Count-1; i >index; i--)
            {
                
                this.elements[i] = this.elements[i-1];
            }
            this.elements[index] = item;
            
        }

        public void Clear() //clearing the list
        {
            for (int i = 0; i < this.Count-1; i++)
            {
                this.elements[i] = default(T);
            }
        }

        public int FindByValue (T item) //finding element by its value and return its index
        {
            int index = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(item))
                {
                    index = i;
                }
            }
            return index;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                result.Append(this.elements[i]);
                if (i != this.Count-1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        private void AutoGrow() //expand capacity if adding or inserting
        {
            T[] newElements = new T[2 * this.Capacity];
            for (int i = 0; i < this.Capacity ; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }

        public T MinValue ()
        {
            var minValue = this.elements[0];
            for (int i = 0; i < this.Count - 1; i++)
            {
                if (this.elements[i+1].CompareTo(minValue) < 0)
                {
                    minValue = this.elements[i+1];
                }
                
            }
            return minValue;
        }

        public T MaxValue()
        {
            var maxValue = this.elements[0];
            for (int i = 0; i < this.Count - 1; i++)
            {
                if (this.elements[i + 1].CompareTo(maxValue) > 0)
                {
                    maxValue = this.elements[i + 1];
                }

            }
            return maxValue;
        }
    }
}
