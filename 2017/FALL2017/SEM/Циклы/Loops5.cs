using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops5
{
    class Program
    {
        static void Main(string[] args)
        {string str = Console.ReadLine();
            int a=0;
            int b=0;
            int c=0;
            int k = 0;
            int quantity = 1;
            while (str != " ")
            {   
                str = Console.ReadLine();
                if (str == ")")
                { a++; c = 1; }
                else if (str == "(")
                {b ++; c = -1; }
                if (k == c) quantity++;
                else quantity = 0;
            }
            if (a == b) Console.WriteLine("The expression is correct? Yes");
            else Console.WriteLine("The expression is correct? No");
            Console.WriteLine(quantity);

         


        }
    }
}
