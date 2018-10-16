using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class hashSet
    {
        static void Main(string[] args)
        {
            var list = new HashSet<int>();// { "naresh","naresh", "lokesh", "suresh","lokesh", "mahesh", "hshhjh","swath","HJg" };
            list.Add(1);
            list.Add(2 );
            list.Add( 13 );
            list.Add( 14 );
            list.Add( 15 );
            list.Add( 16 );
            list.Add( 17 );
            list.Add( 18 );
            list.Add( 19 );
            list.Add( 110 );
            list.Add( 111 );
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
         //   list.Remove("naresh");
         
        }
    }
}
