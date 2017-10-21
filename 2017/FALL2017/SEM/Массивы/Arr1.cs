using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr1
{
    class Program
        
    {
        public static void Revers(int[] a, int start, int finish)
        {
            int flag = 0;
            int distance = finish - start;
            for (int j = 0; j < distance / 2; j++)
            {
                
                flag = a[start];
                a[start] = a[finish-j-1];
                a[finish - j - 1] = flag;
                start += 1;
            
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество переменных в массиве");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите к- сдвиг");
            int k = int.Parse(Console.ReadLine());
            int[] a = new int[count];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Revers(a, 0, a.Length);
            Console.WriteLine("Массив");
            foreach (var e in a)
                Console.Write(e);
            Revers(a, k, a.Length );
            Console.WriteLine("Массив");
           
            foreach (var e in a)
                Console.Write(e);
            Revers(a, 0, k);
            Console.WriteLine("Массив");
            foreach (var e in a)
                Console.Write(e);



        }
    }
}
