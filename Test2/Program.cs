using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        void swapByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        void swapByReference(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a = 1; int b = 5;
            Program p = new Program();

            Console.WriteLine("Nilai x: " + a);
            Console.WriteLine("Nilai x: " + b);

            p.swapByValue(a, b);

            Console.WriteLine("nilai x by val setelah swap :" + a);
            Console.WriteLine("nilai x by val setelah swap :" + b);

            p.swapByReference(ref a, ref b);

            Console.WriteLine("nilai x by ref setelah swap : " + a);
            Console.WriteLine("nilai x by ref stelah swap : " + b);
            Console.ReadKey();
        }
    }
}
