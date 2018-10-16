using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> list = new Dictionary<int, string>();
            list.Add(1, "naresh");
            list.Add(2, "nalini");
            list.Add(3, "nitya");
            list.Add(4, "samanta");
            list.Add(5, "kajal");
            list.Add(6, "pawan");
            Console.WriteLine("total elements are");
            foreach (var i in list)
            {
                Console.WriteLine(i.Key + " " + i.Value);

            }
            Console.WriteLine("after removing elements");
            list.Remove(4);
            list.Remove(2);
            foreach( var i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
