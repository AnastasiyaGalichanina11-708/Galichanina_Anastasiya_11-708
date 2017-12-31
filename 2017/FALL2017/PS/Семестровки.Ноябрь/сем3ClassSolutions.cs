using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solver
{
    public class ClassSolutions
    {
        public static double Element(double x)
        {
            return Math.Sin(Math.Tan(x));
        }
        public static double SumMethodOfTheLeft(int n)
        {
            double sum = 0;
            double a = 0;
            double step = 1.2 / n;
            for (int i = 0; i <= n - 1; i++)
            {
                sum += step * Element(a);
                a += step;
            }
            return sum;
        }

        public static double SumMethodOfTheRight(int n)
        {
            double sum = 0;
            double a = 0;
            double step = 1.2 / n;
            for (int i = 1; i <= n; i++)
            {
                sum += step * Element(a);
                a += step;
            }
            return sum;
        }


        public static double ElementOfMonteKarlo(int x, int n)
        {
			// ---check--- а зачем поднимать наверх его? на этом интервале функция принимает положительные значения
            return Math.Abs(Math.Sin(Math.Tan(x * 0.00001)));// с помощью модуля поднимаем график наверх, и поэтому рассматрриваем площадь S=(х2-х1)(y2-y1)=1.2*1
        }
        public static double MethodMonteKarlo(int n)
        {
            int k = 0;
            var random = new Random();
            double area = 1.2; //площадь на участке x э [0;1.2], y э [0; 1]
            for (int i = 0; i <= n; i++)
            {
				// ---check--- почему вы генерируете случайные числа в интервале [0, 12000]??
                var x = random.Next(0, 12000);
                var y = random.Next(0, 10000);
                if (ElementOfMonteKarlo(x, n) > (y * 0.00001))
                    k += 1;
            }
            return area * k / n;
        }
        public static double SimpsonsMethod(double a, double b, int n)
        {
            double x, step, sum;
            step = (b - a) / n;
            sum = 0; x = a + step;
            while (x < b)
            {
                sum = sum + 4 * Element(x);
                x = x + step;
                sum = sum + 2 * Element(x);
                x = x + step;
            }
            return step / 3 * (sum + Element(a) - Element(b));
        }
        public static double SumMethodTrapezium( int n)
        {
            double a = 0;
            double step = 1.2 / n;
            double sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                sum += (Element(a) + Element(a + step)) / 2;
                a += step;
            }
            return 1.2 / n * sum;
        }
    }
}
