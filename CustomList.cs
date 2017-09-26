using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        int capacity;
        int count;
        
        public void Add(T itemToAdd)
        {
            capacity = 4;
            count = 0;

            T[] items = new T[capacity];
            T[] addingArray = new T[capacity];

            if (count >= capacity) //Just because I can't imagine a way count could be bigger than capacity doesn't mean I shouldn't account for the possibility
            {
                IncreaseCapacity(capacity);
            }

            for (int i = 0; i < count; i++)
            {
                addingArray[i] = items[i];
                i++;
            }

            count++;
            addingArray[count - 1] = itemToAdd;
            items = addingArray;
        }

        public void IncreaseCapacity(int capacity)
        {
            capacity = capacity * 2;
        }

        public void Remove(T itemToRemove)
        {
            
        }

       





    public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
