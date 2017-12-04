using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сем2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int result = a2;
	    // ---check--- почему формулой не воспользововались?
            for (int i = 3; i <= k; i++)
            {
                result += a2 - a1;
            }
            Console.Write("A" + k + " = " + result);
        }
    }
}
