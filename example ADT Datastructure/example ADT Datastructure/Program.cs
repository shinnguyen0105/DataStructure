using System;

namespace example_ADT_Datastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i, n, vitri, moi, vitrixoa, phantutim;
            Console.WriteLine("Length of Array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} numbers:", n );
            for (i = 0; i < n; i++)
            {
                Console.Write("Number - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //In mang vua nhap
            Console.WriteLine("Array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

            ////Gia tri muon chen
            //Console.WriteLine("\nThe number wants to convert: ");
            //moi = Convert.ToInt32(Console.ReadLine());

            ////Vi tri muon chen
            //Console.WriteLine("Number Location of new number in Array: ");
            //vitri = Convert.ToInt32(Console.ReadLine());
            //for (i = n; i >= vitri; i--)
            //    arr[i] = arr[i - 1];
            //    arr[vitri - 1] = moi;

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
            //    Console.Write("  {0}", arr[i]);
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

            //Sap xep mang
            int tmp, j;
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        //cach trao doi gia tri
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
