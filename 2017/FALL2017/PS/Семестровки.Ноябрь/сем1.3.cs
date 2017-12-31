using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cем_1._3
{
    class Program

    {
        static int k = 1;
        public static bool CheckX(double x)
        {
            bool belonging = false;
            if ((x <= 1) && (x>-1))
                belonging = true;
            return belonging;
        }
       
            public static int Check(double e, double x)
            {
                while (Math.Abs(SumElementK(x, k) - SumElementK(x, k + 1)) > e)
                {
                    k += 1;
                }
                return k;
            }
            public static double Sum(double x, int k)
            {
                double sum = 0;
                for (int i = 1; i <= k; i++)
                    sum += SumElementK(x, i);
                return sum;
            }


            public static double SumElementK(double x, int k)
            {
				// ---check--- здесь то же самое
                return (Math.Pow(-1, k + 1) * Math.Pow(x, k)) / k) ;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Введите переменную х");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите тоность е");// как перевести .
                double e = double.Parse(Console.ReadLine());
            if (CheckX(x))
            {
                k = Check(e, x);
                Console.WriteLine(Sum(x, k));
                Console.WriteLine(k);
            }
            else Console.WriteLine("х не удовлетворяет условию -1 < x <= 1");
            }        
    }
}
