 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лампочки
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n;
            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine());
                var status = new Dictionary<int, int>();
                for (int j = 1; j <= n; j++)
                {
                    if (n % j == 0)
                        if (!status.ContainsKey(n))
                            status[n] = 1;
                        else
                            status[n] = (status[n] + 1) % 2; 

                }
                Console.WriteLine(status[n]);
            }







        }
    }
}
