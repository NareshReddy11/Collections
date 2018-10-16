using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class stack
    {
        static void Main(string[] args)
        {
            var list = new Stack<int>();//Stack<string> list=new Stack<string>();
            list.Push(23);
            list.Push(37);
            list.Push(27);
            list.Push(89);
            list.Push(302);
            list.Push(333);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("peek element is:" + list.Peek());
            Console.WriteLine("pop element is:" + list.Pop());
            Console.WriteLine("peek element is:" + list.Peek());

        }
    }
}
