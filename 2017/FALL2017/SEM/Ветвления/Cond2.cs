using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cond2
{
    class Program
    {
        static void Main()
        {       int a = int.Parse(Console.ReadLine());// Не знаю как записать метод чтобы он мог спокойно возращать значение 
                int b = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int z = int.Parse(Console.ReadLine());

            public static bool Bar() 
            {
             return ((x <= a && y <= b) || (x <= a && z <= b) || (z <= a && y <= b));
            }
        }
    }
}