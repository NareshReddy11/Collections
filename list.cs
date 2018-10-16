using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class list
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "naresh", "swathi", "mahesh", "lokesh", "suresh" };
            foreach(var ss in list)
            {
                Console.WriteLine(ss);
            }
            list.RemoveAt(3);
            Console.WriteLine("after removing the elements");
            foreach (var ss in list)
            {
                Console.WriteLine(ss);
            }
            List<string> list1 = new List<string> { "lokesh", "nitya" };
            list.AddRange(list1);
            Console.WriteLine("after adding elements");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }

        }
        
    }
}