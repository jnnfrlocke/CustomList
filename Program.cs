using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomList
{
    class Program
    {
        public static void Main()
        {
            CustomList<int> start = new CustomList<int>();
            //start.Add(3, 2, 4, 1, 5, 0, 15, 14, 16, 13, 17, 12, 18, 11, 19, 10, 20, 9);
            start.Add(2);
            start.Add(4);
            start.Add(1);
            start.Add(5);
            start.Add(0);
            start.Add(15);
            start.Add(14);
            start.Add(16);
            start.Add(13);
            start.Add(17);
            start.Add(12);
            start.Add(18);
            start.Add(11);
            start.Add(19);
            start.Add(10);
            start.Add(20);
            start.Add(9);

            start.Remove(15);
            start.Remove(4);

        }
    }
}

   