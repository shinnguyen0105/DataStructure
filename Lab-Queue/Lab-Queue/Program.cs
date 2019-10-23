using System;

namespace Lab_Queue
{
    public class Queue
    {
        // O(1) 
        public int max;
        public char[] Q;
        public int r = 0;
        public int f = 0;

        public Queue(int max, char[] Q)
        {
            this.max = max;
            this.Q = Q;
        }

        public int Enum()
        {
            // O(1)
            if (r == f)
            {
                return 0;
            }
            else
                return (((max - f) + r) % max);
        }
        public bool Isempty()
        {
            // O(1)
            if (f == r)
            {
                Console.WriteLine("Queue is empty");
                return true;
            }
            else
                return false;
        }
        public bool Isfull()
        {
            // O(1)
            if ((((max - f) + r) % max) == (max - 1))
            {

                Console.WriteLine("Queue is full");
                return true;
            }
            else
                return false;
        }
        public char Peek()
        {
            return Q[f];
        }
        public void Enqueue(char x)
        {
            // O(1)
            if (Enum() == max)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                Q[r] = x;
                r = (r + 1) % max;
            }
            
        }
        public char Dequeue()
        {
            // De - O(1)
            char De;
            De = Q[f];
            f = (f + 1) % max;
            return De;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Que = new char[50];
            Queue myQueue = new Queue(50, Que);
            Console.WriteLine("Nhap chuoi muon them vao Queue: ");
            string input = Console.ReadLine();
            Que = input.ToCharArray();
            foreach (var item in myQueue.Q)
            {
                Console.Write("Chuoi cua ban: " + item);
            }
            Console.WriteLine("\n Number elements: {0}", myQueue.Enum());
            Console.WriteLine("\nr: {0} f: {1}", myQueue.r, myQueue.f);
            Console.ReadKey();

        }
    }
}


// vi du 1 cai class goi ra 1 lan thoi, su dung no 1 lan khong dung` lai la O(1)
// 1 while hoac 1 for la` O(n)
// 2 while long` len nhau, hoac 2 for long` len nhau hoac 1 while 1 for la` O(N^2) 3 cai' la` O(N^3)
// con` tum` lum cha co' noi. no' vua` while vua for vua` if thi` O(Log N) =)))
// la sao a, cai cuoi a bbat vietkey len di :v 
// còn vừa while, trong while có cả wwhile có cả if, 1 đống thứ thì đó là O(Log N)
// ví dụ có if không thì sao a??
// 1 if không thì như trên O(1) vì if nó dùng 1 lần, tức là chạy 1 lần
// while nó chạy n lần vì thế nên mới là O(n), ok a :D
// còn 2 cái while là N^2 lần vì thế là O(N^2), tương tự 3 cái 4 cái rồi tính/
// ez k :v
// e hiểu roài :D
// a mất 30p xem video mới hiêu, chứ đọc trên mạng thì k :v haha đọc mông lung vl -.-

    // cái đề nó mông lung nữa, hỏi kiểu chung chung k biết trả lời ra sao cho đúng
    // e mới làm 20 trang hết ý tương -_-