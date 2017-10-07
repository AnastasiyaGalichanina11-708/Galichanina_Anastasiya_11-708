using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int amount = 0;
            for (int  a=0; a <10; a++)
            { for (int b = 0; b < 10; b++)
                { for (int c = 0; c < 10; c++) {
                        if (a + b + c == n) amount++; }
                }
            }
            Console.WriteLine(amount);
        }
    }
}
