using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {

        private T[] items;
        private int count;

        private int capacity;


        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
            set
            {
                items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }


        //Check if we have reached max capacity
        //create a temp array to hold the original values
        //double the size of our items array
        //using a for loop, pass each value from out temp array into our new larger items array
        public void Add(T item)
        {
            T[] tempArray;
            
            items[count] = item;
            count++;
            if (count == capacity)
            {
                tempArray = items;
                capacity = capacity * 2;
                items = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    items[i] = tempArray[i];
                }
            }           

        }
        //Capacity = 4
        //Count = 0
        //null null null null
        //Add(23)
        //Add(56)
        //Add(87)
        //23 56 87 null
        //Add(2)
        //23 56 87 2
        //Count = 4
        //Capacity = 4
        //increase the size of our items by double
        //After we increase capacity...
        //23 56 87 2 null null null null
        //Add(30)
        //23 56 87 2 30 null null null


        public void Remove(T item)
        {
            items[count] = item;
            count--;
        }
        
    }
}
