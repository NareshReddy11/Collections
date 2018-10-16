using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class arraylistremove
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(111);
            list.Add(999);
            list.Add("naresh");
            list.Add("swathi");
            Console.WriteLine("before removing");
            foreach(var i in list)

            {
                Console.WriteLine(i);
            }
            // list.Remove(999);
            list.RemoveAt(1);
            Console.WriteLine("after removing");
            foreach(var ss in list)
            {
                Console.WriteLine(ss);
            }
        }
    }
}
