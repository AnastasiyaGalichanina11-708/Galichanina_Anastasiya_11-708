using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cond3
{
    class Program
    {   public static int Length(int a, int b)
        {
        return  Math.Abs(a - b);
        }
        public static double Hypotenuse(int c, int d)
        {
            return Math.Sqrt(c * c + d * d);
                }
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine()); // точка  x1, y1 всегда стоит в угле 90  град
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            if (Length(x1,x2)==Length(y1,y3) && Hypotenuse(Length(x1,x2), Length(y1,y3))==Length(x1,x2)*Math.Sqrt(2))
            { if (x1 < x2 && y1 < y2)
                    Console.WriteLine("Четвёртая точка: (" + x1 + Length(x1, x2) + "," + y1 + Length(y1, y3) + ")");
                else if (x1 > x2 && y1 < y2)
                    Console.WriteLine("Четвёртая точка: (" + x2 + "," + y1 + Length(y1, y3) + ")");
                     else if (x1 > x2 && y1 > y2)
                    Console.WriteLine("Четвёртая точка: (" + x1 + Length(x1, x2) + "," + y1 + Length(y1, y3) + ")")// Программа ещё не закончена
                      else


        }
    }
}
