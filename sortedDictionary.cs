using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class sortedDictionary
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> list = new SortedDictionary<int, string>();
            list.Add(3, "naresh");
            list.Add(7, "mahesh");
            list.Add(1, "suresh");
            list.Add(4, "shanti");
            list.Add(2, "dady");
            list.Add(5, "nitya");
            list.Add(6, "i hate u");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
