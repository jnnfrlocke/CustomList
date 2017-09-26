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
        T[] items;
        T[] addingArray;

        public void Add(T itemToAdd)
        {
            capacity = 4;
            count = 0;

            items = new T[capacity];
            addingArray = new T[capacity];

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

        public bool Remove(T itemToRemove)
        {
            bool removed = false;

            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(itemToRemove))
                {
                    items[i] = items[i + 1];
                    removed = true;
                }
            }
            return removed;
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
