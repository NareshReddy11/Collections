using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class ArrayInsert
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(222);
            list.Add("naresh");
            list.Add(34);
            list.Insert(1, "swathi");
            list.Insert(2, "i hate u");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
