using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int a=x;
            a = x / 100;
            a += ((x / 10) % 10) * 10; 
            a += (x % 10) * 100;
            Console.WriteLine(a);  
        }
    }
}
