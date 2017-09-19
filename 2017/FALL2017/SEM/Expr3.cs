using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr3
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = Convert.ToInt32(Console.ReadLine());
            if (g > 6 && g <= 12)
            Console.WriteLine((g - 12) * 30);// Для времени от 6 до 12
            else 
            Console.WriteLine(g*30);//с часу до шести

        }
    }
}
