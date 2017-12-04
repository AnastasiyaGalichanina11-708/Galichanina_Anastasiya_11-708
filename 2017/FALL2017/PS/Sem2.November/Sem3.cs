using Solver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число отрезков");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Метод Левых " + ClassSolutions.SumMethodOfTheLeft( n));
            Console.WriteLine("Метод Правых " + ClassSolutions.SumMethodOfTheRight( n));
            Console.WriteLine("Метод Монте-Карло " + ClassSolutions.MethodMonteKarlo(n));
            Console.WriteLine("Метод Симпсона " + ClassSolutions.SimpsonsMethod(0, 1.2, n));
            Console.WriteLine("Метод трапеции " + ClassSolutions.SumMethodTrapezium(n));
        }
    }
}

