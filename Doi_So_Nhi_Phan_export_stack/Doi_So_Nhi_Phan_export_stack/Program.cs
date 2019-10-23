using System;
using System.Collections;
using System.Collections.Generic;

namespace Doi_So_Nhi_Phan_export_stack
{
    public class Stack
    {
        public int[] data = new int[20];
        public int top;
    }
    class Program
    {
        public static Boolean IsFull(Stack S)  
        {
            if (S.top == S.data.Length - 1)       
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static Boolean IsEmpty(Stack S)  
        {
            if (S.top == -1)                     
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Push(Stack S, int x) 
        {
            if (IsFull(S) == false)            
            {
                S.top++;                      
                S.data[S.top] = x;            
            }
            else
            {
                Console.WriteLine("Full");
            }

        }
        public static void Pop(Stack S)        
        {
            if (IsEmpty(S) == false)            
            {
                S.top--;
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
        public static void Peek(Stack S)       
        {
            if (IsEmpty(S) == false)           
            {
                Console.WriteLine("Top Element: " + S.data[S.top]);
            }
            else
            {
                Console.WriteLine("Stack Underflow");
            }
        }
        public static void NumberElement(Stack S)
        {
            string str = " ";
            for (int i = S.top; i >= 0; i--)    
            {
                str += S.data[i] + " ";
            }
            Console.WriteLine("Element: " + str);
        }

        static void Main(string[] args)
        {
            Stack S = new Stack();
            int n;
            int r;
            Console.WriteLine("Nhap so can chuyen: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                r = (n % 2);
                Push(S, r);
                n = (n / 2);
            }

            Console.WriteLine("Nhi phan sau khi doi: ");
            NumberElement(S);
            Console.WriteLine("Ban muon lam gi: ");
            Console.WriteLine("1. Lay ra mot phan tu va in stack");
            Console.WriteLine("2. Phan tu top la gi?");

            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Pop(S);
                    Console.WriteLine("===============");
                    NumberElement(S);
                    break;
                case 2:
                    Peek(S);
                    break;
                default:
                    break;
            }
            
            

        }
    }
}
