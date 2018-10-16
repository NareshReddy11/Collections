using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class hashTable
    {
        static void Main(string[] args)
        {
            Hashtable list = new Hashtable();
            list.Add(1, "naresh");
            list.Add(2, 2);
            list.Add(7, "suresh");
            list.Add(0, "suresh");
            list.Add(4, "suresh");
            list.Add(5, "suresh");
            foreach(var i in list.Values)
            {
                Console.WriteLine(i);
            }

        }
    }
}
