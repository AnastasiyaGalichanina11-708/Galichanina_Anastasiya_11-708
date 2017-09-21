using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());//x1,y1 координаты точки А 
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());//x2,y2 координаты 1 точки прямой 
            int y2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.ReadLine());//x2,y3 координаты 2 точки прямой
            int y3 = Convert.ToInt32(Console.ReadLine());
            double a = Math.Sqrt ((x2 - x1) * (x2 - x1) + (y2 - y1)*(y2 - y1));// длина отрезка от А до точки 1
            double b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));// длина отрезка от 1 до точки 2
            double c = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));// длина отрезка от А до точки 2
            double p = (a + b + c) / 2;  // полупериметр
            double S = Math.Sqrt (p*(p-a)*(p-b)*(p-c));// формула Геррона
            double h = 2 * S / b; // площадь треугольника
            Console.WriteLine(h);
        }
    }
}
