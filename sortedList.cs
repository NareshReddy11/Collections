using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class sortedList
    {
        static void Main(string[] args)
        {
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(6, "hfgjh");
            list.Add(1, "hfgjh");
            list.Add(7, "hfgjh");
            list.Add(2, "hfgjh");
            list.Add(5, "hfgjh");
            list.Add(3, "hfgjh");
            list.Add(8, "hfgjh");
            list.Add(4, "hfgjh");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            list.RemoveAt(4);
            list.RemoveAt(1);
            list.RemoveAt(2);
            Console.WriteLine("afte removing");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
