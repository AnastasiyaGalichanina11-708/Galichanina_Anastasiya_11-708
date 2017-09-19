using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());//a -часы
            int b = Convert.ToInt32(Console.ReadLine());// b-минуты
            int c = b * 6;// градусы минут
            double d = (a * 30) + b*0.5;
            if (c - d > 0)
                Console.WriteLine(c - d);
            else
                Console.WriteLine(d - c);





        }
    }
}
