using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сем5
{
    class Program
    {
        
        static void Main(string[] args)
        { Console.WriteLine("Введите число к не меньшее 2");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число m не меньшее 2");
            int m = int.Parse(Console.ReadLine());
            int amount = 0;
	    // ---check--- почему до 10?
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        if (Math.Pow(x,k)==Math.Pow(y,k)+Math.Pow(z,k)%m && (x >= 0 && x <= m - 1) &&
                            (y >= 0 && y <= m - 1) && (z >= 0 && z <= m - 1)) amount++;
                    }
                }
            }
            Console.WriteLine(amount);
        }
    }
}
