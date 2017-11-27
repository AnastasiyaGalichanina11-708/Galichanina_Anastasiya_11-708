using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сем_1._2
{
    class Program
    {
        static int k = 0;
        static void Main(string[] args) //главный метод
        {
            Console.WriteLine("Введите переменную х");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите тоность е");
            double e = double.Parse(Console.ReadLine());
            if (CheckX(x))
            {
                k = CheckAccuracy(e, x);
                Console.WriteLine(Sum(x, k));
                Console.WriteLine(k);
            }

            else Console.WriteLine("х не удовлетворяет условию |x|<1");
        }

        public static bool CheckX(double x) //проверяет в каком промежутке находится х
        {
            bool belonging = false;
            if (Math.Abs(x) < 1)
                belonging = true;
            return belonging;
        }
           
        public static int CheckAccuracy(double e, double x)  //проверяет точность
        {
            while (Math.Abs(ElementK(x, k) - ElementK(x, k + 1)) > e)
            {
                k += 1;
            }
            return k;
        }
        public static double Sum(double x, int k)  //суммирует
        {
            double sum = 0;
            for (int i = 0; i <= k; i++)
                sum += ElementK(x, i);
            return sum;
        }
            
        
        public static double ElementK(double x, int k) //Вычисляет формулу при k
        {
            return Math.Pow(-1, k) * Math.Pow(x, k) * (1 + k); 
        }
        
    }
}
