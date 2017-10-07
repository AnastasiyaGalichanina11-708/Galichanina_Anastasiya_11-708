using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сем4
{
    class Program
    {
        public static double DistanceFromCenterToPoint(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double centerX = double.Parse(Console.ReadLine());
            double centerY = double.Parse(Console.ReadLine());
            double radius = double.Parse(Console.ReadLine());
            double distance = double.MaxValue;
            double finalX=0;
            double finalY=0;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double distLocal = DistanceFromCenterToPoint(x, y, centerX, centerY);
                if (distLocal < distance && distLocal > radius && distLocal != radius)
                {
                    distance = distLocal;
                    finalX = x;
                    finalY = y;
                }
            }
            Console.WriteLine("" + finalX + ";" + finalY + ")");
        }
    }
}
     