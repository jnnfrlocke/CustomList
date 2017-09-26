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
        public int capacity;
        int count;
        T[] items;

        public void Add(T itemToAdd)
        {
            capacity = 4;
            count = 0;

            items = new T[capacity];
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

        public override string ToString() // TODO: need arguments/parameters
        {
            string result = items[0].ToString();
            
            for (int i = 1; i < count; i++)
            {
                result = result + " " + items[i].ToString();
            }
            return result;
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2) //Overload plus operator
        {
            if (list1 != null && list2 != null)
            {
                for (int i = 0; i < list2.count; i++)
                {
                    list1.Add(list2.items[i]);
                }
            }
            return list1;
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2) //Overload minus operator
        {
            if (list1 != null && list2 != null)
            {
                for (int i = 0; i < list2.count; i++)
                {
                    list1.Remove(list2.items[i]);
                }
            }
            return list1;
        }

        public void Zipper(CustomList<T> list1, CustomList<T> list2)
        {
            if (list1.count <= list2.count)
            {
                for (int i = 0; i < list1.count; i++)
                {
                    list1.Add(list1.ElementAt(i));
                    list2.Add(list2.ElementAt(i));
                }
            }
            else
            {
                for (int i = 0; i < list2.count; i++)
                {
                    list1.Add(list1.ElementAt(i));
                    list2.Add(list2.ElementAt(i));
                }
            }
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
