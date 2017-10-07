using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            string str = Console.ReadLine();
            int st = int.Parse(str);
            for (int i =st%10; i>0; i--)
                j = (j +i) * 10;
            Console.WriteLine(j/10);
        }
    }
}
