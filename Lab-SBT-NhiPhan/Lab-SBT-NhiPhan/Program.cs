using System;

namespace Lab_SBT_NhiPhan
{
    class node
    {
        int data;
        node L, R;
        public node(int x)
        {
            data = x;
            L = null;
            R = null;
        }
        public void Insert(int x, node T)
        {
            if (T == null)
            {

                T = new node(x);
            }
            else if (x > T.data)
            {
                Insert(x, T.R);
            }
            else Insert(x, T.L);
        }
        public void In_order(node T)
        {
            if (T == null)
            {
                Console.WriteLine("Null");
            }
            else
                In_order(T.L);
                Console.WriteLine(T.data);
                In_order(T.R);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number element wants to import: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Element 1: ");
            int el = Convert.ToInt32(Console.ReadLine());
            node mynode = new node(el);
            for (int i = 2; i <= input ; i++)
            {
                Console.WriteLine("Element {0}: ", i);
                el = Convert.ToInt32(Console.ReadLine());
                mynode.Insert(el, mynode);

            }
            mynode.In_order(mynode);
            Console.ReadKey();
        }
    }
}
