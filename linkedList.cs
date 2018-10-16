using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class linkedList
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<string>();
            list.AddFirst("naresh");
            list.AddLast("mahesh");
            list.AddFirst("swathi");
            list.AddFirst("reddy");
            list.AddLast("suresh");
            list.AddLast("lokesh");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            LinkedListNode<string> node = list.Find("lokesh");
            list.AddBefore(node, "swapna");
            list.AddAfter(node, "shanthi");
            Console.WriteLine("some more elements adding");
            foreach (var items in list) 
            {
               Console.WriteLine(items);
            }
           
        }
    }
}
