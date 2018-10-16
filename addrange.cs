using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class addrange
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(234);
            list.Add("naresh");
            list.Add("hdsbb");
            ArrayList list1 = new ArrayList();
            list1.Add("swathi");
            list1.Add("mahesh");
            list.AddRange(list1);
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
