using System;
using System.Diagnostics;
namespace Lab_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // 101 201 401 801 1001 1201 1501 1701 2000
            int i, j, n, vitri, moi, vitrixoa, phantutim;
            Stopwatch st = new Stopwatch();
            int[] arr = new int[2000];
            Random rnd = new Random();
            Console.WriteLine("Length of Array:");
            n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter {0} numbers:", n);
            for (i = 0; i < 2000; i++)
            {
                //Console.Write("Number - {0} : ", i+1);
                arr[i] = rnd.Next(1, 2000);
            }
            ////In mang vua nhap
            Console.WriteLine("Array: ");
            for (i = 0; i < 2000; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            ////Gia tri muon chen
            //Console.WriteLine("\nThe number wants to convert: ");
            //moi = Convert.ToInt32(Console.ReadLine());
            ////Vi tri muon chen
            //Console.WriteLine("Number Location of new number in Array: ");
            //vitri = Convert.ToInt32(Console.ReadLine());
            //for (i = n; i >= vitri; i--)
            //    arr[i] = arr[i - 1];
            //arr[vitri - 1] = moi;

            ////In mang sau khi chen
            //Console.Write("\n\nAfter convert new number in Array:\n");
            //for (i = 0; i <= n; i++)
            //    Console.Write("{0} ", arr[i]);
            //Console.Write("\n\n");
            ////Xoa phan tu trong mang
            //Console.Write("\nNhap vi tri can xoa: ");
            //vitrixoa = Convert.ToInt32(Console.ReadLine());
            ////tim i
            //i = 0;
            //while (i != vitrixoa - 1)
            //    i++;
            ////dua phan tu ben phai qua thay the phan tu moi
            //while (i < n)
            //{
            //    arr[i] = arr[i + 1];
            //    i++;
            //}
            //Console.Write("\n Array after delete: ");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(" {0}", arr[i]);
            //}
            //Console.WriteLine("\n Nhap phan tu can tim");
            //phantutim = Convert.ToInt32(Console.ReadLine());
            //for (i = 0; i <= n; i++)
            //{
            //    if (arr[i] == phantutim)
            //    {
            //        Console.WriteLine("Vi tri cua {0} la {1}", phantutim, i);
            //    }
            //}
            st.Start();
            long time = 600000000L;
            ////Sorting Array - Bubble method
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            //In mang sau khi sap xep
            Console.WriteLine("\nArray after Bubble sorting: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            st.Stop();
            Console.WriteLine("                               ");
            Console.WriteLine("\n{0} giay", st.Elapsed.ToString());
            if (Stopwatch.IsHighResolution)
                Console.WriteLine("Timed with Hi res");
            else Console.WriteLine("Not Timed with Hi res");
            Console.WriteLine("----------------------------");
            st.Start();
            //Sorting Array - Selection method
            for (i = 0; i < (n - 1); i++)
            {
                int min = i;
                for (j = 0; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }

                }
                int tmp = arr[min];
                arr[min] = arr[j];
                arr[j] = tmp;
            }
            Console.WriteLine("\nArray after use Selection sorting: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            st.Stop();
            Console.WriteLine("                               ");
            Console.WriteLine("\n{0} giay", st.Elapsed.ToString());
            if (Stopwatch.IsHighResolution)
                Console.WriteLine("Timed with Hi res");
            else Console.WriteLine("Not Timed with Hi res");
            Console.ReadKey();

        }
    }
}
