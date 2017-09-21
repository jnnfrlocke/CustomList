using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    
        public class CustomList<T>
        {
            T[] items;

            public void Add(T itemToAdd)
            {
                items[0] = itemToAdd; //will set later to find the last item in list and add new item after that
                //return items[0];


                //TODO:add indexer
            }
       
        }

    }

