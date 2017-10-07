using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cем3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите систему счисления k");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите систему счисления k");
            int remainder2 = 0;// следующая цифра
            int remainder1 = 0;// предыдущая цифра
            int amount = 0;
            int theBiggestAmounth = 0;
            if (n > Math.Pow(10, 9))
                Console.WriteLine("n<=10^9");
            else
            {
                while (n / k > 0)
                {
                    remainder1 = remainder2;
                    remainder2 = n % k;
                    Console.WriteLine(remainder2);
                    n = n / k;
                    if (remainder1 == remainder2 || 1 - remainder1 == remainder2)
                        amount++;
                    else amount = 1;
                    if (theBiggestAmounth < amount)
                        theBiggestAmounth = amount;

                    Console.WriteLine(amount);
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine(theBiggestAmounth);//Не закончена, не выводит всех цифр, а именно первого разряда.
        }                                        //8-это 000, вместо 1000
    }
}
