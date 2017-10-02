
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cond3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int a = x / 100000;
            int b = (x/ 10000)%10;
            int c = (x / 1000)%10;
            int d = (x / 100) % 10;
            int e = (x / 10) % 10;
            int f = x % 10;
            if (f == 0 || f == 9) Console.WriteLine("No");
            else if (a + b + c - 1 == e + d + f) Console.WriteLine("Yes");
            else if (a + b + c + 1 == e + d + f) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}

       

 