using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сем1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            if (b / 100000 + (b / 10000) % 10 + (b / 1000) % 10 == (b / 100) % 10 + (b / 10) % 10 + b % 10)
            {
                Console.Write("Lucky");
            }
            else
            {
                Console.Write("No luck");
            }
        }
    }
}
