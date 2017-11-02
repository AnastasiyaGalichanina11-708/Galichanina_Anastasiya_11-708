using Solver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лампочки_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n, status;
            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine());
                status = LampSolver.ReturnStatus(n);
                Console.WriteLine(status);
            }
        }

        


    }

}
