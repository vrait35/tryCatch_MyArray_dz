using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    public class MyArray<T>
    {
        public int Count { get; set; }
        public T[] Array { get; set; }
        public int Capacity { get; set; }
        public T this[int index]
        {
            get
            {
                return Array[index];
            }
            set
            {
                try
                {
                    try
                    {
                            T buf = Array[index];                        
                    }
                    catch
                    {
                        Count++;
                    }
                    Array[index] = value;                    
                }
                catch
                {
                    throw new ArgumentException("выход за пределы массива! ");
                }
            }
        }

        public MyArray()
        {
            Array = null;
            Count = 0;
            Capacity = 0;
        }

        public MyArray(int capacity):base()
        {
            this.Capacity = capacity;
            Array = new T[Capacity];
        }

        public void Resize(int newSize)
        {
            if (Count > 0)
            {
                T[] buf = new T[Count];
                for (int i = 0; i < Count; i++)
                    buf[i] = Array[i];

                Array = new T[newSize];

                int min = Math.Min(newSize, Count);

                for (int i = 0; i < min; i++)
                    Array[i] = buf[i];

                Count = min;
            }
            else if (Count == 0)
            {
                Array = new T[newSize];
            }
            Capacity = newSize;
        }

        public void Show()
        {
            foreach(T a in Array)
                Console.Write(a+"  ");
            Console.WriteLine("\n");
        }

    }
}
