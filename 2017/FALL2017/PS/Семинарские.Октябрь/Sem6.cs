using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сем6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double summ = 0;
            for (double i = Math.Pow(10, n - 1); i < Math.Pow(10, n); i++)
            {
                summ += i;
            }
            Console.Write("Summ = " + summ);
        }
    }
}
