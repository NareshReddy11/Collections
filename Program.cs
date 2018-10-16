using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(100);
            list.Add("naresh");
            list.Add(200.45);
            list.Add(45.5f);
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
