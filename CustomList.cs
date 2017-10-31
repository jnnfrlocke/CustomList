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
        private int capacity;
        public int count;
        T[] items;

        //Count
        public int Count
        {
            get { return count; }
        }
        
        // Indexer //public T CustomList this[int index]
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        //Initialize items array
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        //Add
        public void Add(T itemToAdd) //This works for adding one number to an empty array at a time, need to make it work for multiple (overload?)
        {
            if (count >= capacity - 1)
            {
                IncreaseCapacity(capacity);
            }
            items[count] = itemToAdd;
            count++;
        }

        //Increase capacity
        public int IncreaseCapacity(int capacity)
        {
            capacity = count + 1;
            T[] newArray = new T[capacity];

            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
            return capacity;
        }

        //ADDS TWO LISTS TOGETHER
        public static CustomList<T> operator + (CustomList<T> list1, CustomList<T> list2) //Overload plus operator???
        {
            CustomList<T> list3 = new CustomList<T>();
            if (list1 != null && list2 != null)
            {
                for (int i = 0; i < list2.count; i++)
                {
                    list3.Add(list1.items[i]);
                }
                for (int i = 0; i < list2.count; i++)
                {
                    list3.Add(list2.items[i]);
                }
            }
            return list3;
        }

        //Overload++
        //public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2) //Overload plus operator
        //{
        //    if (list1 != null && list2 != null)
        //    {
        //        for (int i = 0; i < list2.count; i++)
        //        {
        //            list1.Add(list2.items[i]);
        //        }
        //    }
        //    return list1;
        //}

        //Remove
        public bool Remove(T itemToRemove)
        {
            bool removed = false;

            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(itemToRemove))
                {
                    items[i] = items[i + 1];
                    i++;
                    count--;
                    for (int j = i; j < count; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    removed = true;
                }
            }
            return removed;
        }

        //Overload--
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

        //Iterable
        public void Iterate(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    Console.WriteLine($"{item} was found."); ;
                }
                Console.WriteLine($"{item} was not found.");
            }
        }

        //To String
        public override string ToString() 
        {
            string result = items[0].ToString();

            for (int i = 1; i < count; i++)
            {
                result = result + " " + items[i].ToString();
            }
            return result;
        }

        //Zipper
        public void Zipper(CustomList<T> list1, CustomList<T> list2)
        {
            if (list1.count <= list2.count)
            {
                for (int i = 0; i < list1.count; i++)
                {
                    list1.Add(list1.ElementAt(i)); // Fix - can't use built in .ElementAt
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

                throw new IndexOutOfRangeException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            throw new NotImplementedException();
        }
    }
}
