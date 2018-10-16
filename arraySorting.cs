using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class arraySorting
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(34);
            list.Add(99);
            list.Add(1);
            list.Add(88);
            list.Add(22);
            list.Sort();
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
