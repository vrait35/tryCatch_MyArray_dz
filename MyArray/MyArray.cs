using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    public class MyArray<T>
    {        
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
            Array = new T[0];         
            Capacity = 0;
        }

        public MyArray(int capacity):base()
        {
            this.Capacity = capacity;
            Array = new T[Capacity];
        }

        public void Resize(int newSize)
        {
           
                T[] buf = new T[Capacity];
                for (int i = 0; i < Capacity; i++)
                    buf[i] = Array[i];

                Array = new T[newSize];
              
                int min = (newSize > Capacity) ? Capacity : newSize;

                for (int i = 0; i < min; i++)
                    Array[i] = buf[i];
                
            Capacity = newSize;
            }                 
    }


    }
