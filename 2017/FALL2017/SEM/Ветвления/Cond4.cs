using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cond4
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if ((b - a + d - c) >= (Math.Max(b, d) - Math.Min(a, c))) Console.WriteLine(Math.Min(b, d) - Math.Max(a, c);
            else Console.WriteLine("0"); 
          
        }
    }
}
