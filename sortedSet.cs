using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class sortedSet
    { 
        static void Main(string[] args)
        {
            var list = new SortedSet<string> { "naresh", "lokesh", "swathi", "suresh", "mahesh" };
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
