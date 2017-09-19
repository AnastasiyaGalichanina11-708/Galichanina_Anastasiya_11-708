using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// само число
            int x = int.Parse(Console.ReadLine());// делитель 1
            int y = int.Parse(Console.ReadLine());// делитель 2
            int c =((n/x)+(n/y)-(n/(x*y)));
            Console.WriteLine(c);
        }
    }
}
