using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if (x <= a && y <= b) Console.WriteLine("Yes");
            else if (x <= a && z <= b) Console.WriteLine("Yes");
            else if (z <= a && y <= b) Console.WriteLine("Yes");
            else Console.WriteLine("No");


        }
    }
}
