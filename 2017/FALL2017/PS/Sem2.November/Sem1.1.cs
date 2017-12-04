using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static int k=0;
        public static bool CheckX(double x)//проверка отрезка нахождения х
        {
            bool belonging = false;
            if (Math.Abs(x)>1 )
                belonging = true;
            return belonging;
        }

        public static int Check(double e, double x)//проверка точности
        {
            while (Math.Abs(SumElementK(x, k) - SumElementK(x, k + 1)) > e)
            {
                k += 1;
            }
            return k;
        }
        public static double Sum(double x, int k)//суммирует элементы
        {
            double sum = 0;
            for (int i = 1; i <= k; i++)
                sum += SumElementK(x, i);
            return sum;
        }
        public static double SumElementK(double x, int k)//формула данная в задаче
        {
            return (Math.Pow(-1, k) / (Math.Pow(x, 2 * k + 1) * (2 * k + 1)));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную х");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите тоность е");
            double e = double.Parse(Console.ReadLine());
            double arctg = Math.PI * Math.Sqrt(Math.Pow(x, 2)) / (2 * x);
            if (CheckX(x))
            {
                k = Check(e, x);
                Console.WriteLine(arctg - Sum(x, k));
                Console.WriteLine(k);
            }
            else Console.WriteLine("х не удовлетворяет условию |x|>1");
        }

    }
}
