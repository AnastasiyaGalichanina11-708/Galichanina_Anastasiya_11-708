using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToInt32(Console.ReadLine()); //Ураванение вида y=ax+b 
            double b = Convert.ToInt32(Console.ReadLine());
            double c; //Ураванение вида y=cx+d
            double d;
            double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());

            d = y - c * x;//Пересечение отрезков происходит в одной точке
            c = (-1) / a; // Следует из перпендикулярности прямых
            x = (b - d) / (c - a);
            y = a * x + b;
            Console.WriteLine("(" + x + ";" + y + ")"); 
        }
    }
}
