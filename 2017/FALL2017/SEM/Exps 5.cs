using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int n = y-x;
            int c = ((n / 4) + (n / 100) - (n / (400)));
            Console.WriteLine(c);
        }
    }
}
