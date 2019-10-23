using System;
using System.Diagnostics;
namespace Lab_De_Quy
{
    public class Dequy
    {
        public int TimNgiaithua(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return n * TimNgiaithua(n - 1);
        }
        public int luythua(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return 2 * luythua(n - 1);
        }
        public int Daysoquyluat(int n)
        {
            if (n == 0)
                return 1;
            else return n + Daysoquyluat(n - 1);
        }
        public int Fibonacci_Dequy(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            else return Fibonacci_Dequy(n - 1) + Fibonacci_Dequy(n - 2);
        }
        public void Print_Fib(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(Fibonacci_Dequy(i) + " ");
            }
        }
        public void Fibonacci_vonglap(int n)
        {
            int a =0 , b= 1, c;
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            Dequy gt = new Dequy();
            Console.WriteLine("Nhap so: ");
            int x = Convert.ToInt32(Console.ReadLine());
            st.Start();
            Console.WriteLine(gt.Fibonacci_Dequy(x));
            gt.Print_Fib(x);
            st.Stop();
            Console.WriteLine("                               ");
            Console.WriteLine("\nRecursive: {0} giay", st.Elapsed.ToString());
            //Console.WriteLine(gt.Daysoquyluat(x));

            //Console.Write(gt.TimNgiaithua(x));

            //Console.WriteLine(gt.luythua(x));
            st.Start();
            gt.Fibonacci_vonglap(x);
            st.Stop();
            Console.WriteLine("                               ");
            Console.WriteLine("\nFor: {0} giay", st.Elapsed.ToString());
            Console.ReadKey();
        }
    }
}
