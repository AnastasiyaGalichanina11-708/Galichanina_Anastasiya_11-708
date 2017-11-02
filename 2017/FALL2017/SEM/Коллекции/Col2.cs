using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Col2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.WriteLine("Введите L");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Введие K");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            for (int i = l; i <= k; i++)
                array[i] += x;
            Console.WriteLine("Массив");
            foreach (int e in array)
                Console.Write( e+", ");

        }
    }
}
