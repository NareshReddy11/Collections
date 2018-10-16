using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class insertRange
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1223);
            list.Add("naresh");
            list.Add(65);
            ArrayList list1 = new ArrayList();
            list1.Add(100);
            list1.Add(1000);
            list.InsertRange(1, list1);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
