using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class queue
    {
        static void Main(string[] args)
        {
            Queue<int> list = new Queue<int>();
            list.Enqueue(6);
            list.Enqueue(3);
            list.Enqueue(70);
            list.Enqueue(65);
            list.Enqueue(96);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("peek element is:" +list.Peek() );
            Console.WriteLine("dequeue:" + list.Dequeue());
            Console.WriteLine("peek element is:" + list.Peek());
        }
    }
}
