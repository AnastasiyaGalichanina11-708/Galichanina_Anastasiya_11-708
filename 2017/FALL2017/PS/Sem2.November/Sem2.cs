using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фактор_иалы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точность");
            double eps = double.Parse(Console.ReadLine());
         Console.WriteLine(Sum(eps));
        }

        public static double Sum(double eps)
        {
            double temp, sum = 0;
            int k = 1, pow = 2;
            do
            {
                temp = sum;
                sum +=((double)pow/ C(2 * k, k));
                k++;
                pow *= 2;
            }
            while (Math.Abs(temp - sum) > eps);
            return 2*sum-2;
            
        }
        public static int C(int n, int k)

        {
            if (k == 1) return n;
            if (k == n) return 1;
            return C(n - 1, k) + C(n - 1, k - 1);
        }

    }
}



