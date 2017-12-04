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
            Console.WriteLine("Введите колтчество членов последовательности n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число к");
            int k = int.Parse(Console.ReadLine());
            SumOfProgression(n, k);///////////////ИЗМЕНИТЬ DOUDLE НА INT

        }
        public static int[] Subtraction(int[] arrayN)// высчитывает(n-1)
        {
            if (arrayN[arrayN.Length - 1] == 0)
            {
                arrayN[arrayN.Length - 2] -= 1;
                arrayN[arrayN.Length - 1] = 9;
            }
            else
            arrayN[arrayN.Length - 1] -= 1;
            return arrayN;
        }
        public static void SumOfProgression(int n, int k)
        {
            var arrayN = TranslateIntoAnArray(n);
            var arrayK = TranslateIntoAnArray(k);
            int[] c = MultiplyArrayByArray(Subtraction(arrayN), arrayK);   //(n-1)d
            c[c.Length - 1] += 2;  // 2a+d(n-1)
            if (c[c.Length - 1] + 2 > 9)
                c[c.Length - 2] += 1;
            int[] t = MultiplyArrayByArray(c, arrayN); //(2a+d(n-1))n
            string sum = DivideArrayBy2(t); // (2a+d(n-1))n/2
            Console.WriteLine("КОНЧЕННАЯ Cумма");
            Console.WriteLine(sum);
        }
        public static int[] MultiplyArrayByArray(int[] n, int[] k)// высчитывает d(n-1) // умножает массив на МАССИВ
        {
            var difference = new int[1];
            difference[0] = 0;
            for (int i = k.Length; i > 0; i--)
            {
                var intermediateValue = MultiplyArrayByNumber(n, k[i - 1]);
                difference = AddUp(difference, intermediateValue);
            }
            Console.WriteLine("разница");
            foreach (int e in difference)
                Console.Write(e);
            Console.WriteLine();
            return difference;
        }

        public static int[] TranslateIntoAnArray(int number)//переводит число в массив
        {
            var listOfNumber = new List<int>();
            while (number % 10 > 0)
            {
                listOfNumber.Add(number % 10);
                number =  number / 10;
            }
 //!           //listOfNumber.Reverse();
            var arrayOfNumber = new int[listOfNumber.Count];
            int i = 0;
            foreach (var t in listOfNumber)
            {
                arrayOfNumber[i] = t;
                i++;
            }
            for (int j = 0; j < arrayOfNumber.Length; j++) 
                Console.Write(arrayOfNumber[j]+"c");
            Console.WriteLine();
            return arrayOfNumber;
            
        }

        public static int[] MultiplyArrayByNumber(int[] firstNumber, int k)//Умножает массив на ЧИСЛО
        {
            int q = 0;
            int length = firstNumber.Length;
            var intermediateValue = new int[length+1];// length + 1
            for (int i = length; i > 0; i--)
            {
                intermediateValue[i] = (firstNumber[i-1] * k + q) % 10;
                q = (firstNumber[i-1] * k + q) / 10;
            }
            if (q != 0)
            {
                var result = new int[intermediateValue.Length + 1];
                result[0] = q;
                for (int j = 1; j <= intermediateValue.Length; j++)
                    result[j] = intermediateValue[j - 1];
                Console.WriteLine("Умножение");
                foreach (int e in result)
                    Console.Write(e);
                Console.WriteLine();
                return result;

            }
            else
            {
                Console.WriteLine("Умножение");
                foreach (int e in intermediateValue)
                    Console.Write(e);
                Console.WriteLine();
                return intermediateValue;
            }
        }

        public static int[] AddUp(int[] first, int[] second1)//Суммирует два числа () при умножении в столбике 
        {
            int q = 0;
            
            int shortLeng = first.Length;
            int longLeng = second1.Length;
            int[] second = new int[longLeng + 1];
            second[0] = 0;
            for (int j = 1; j < longLeng; j++)
                second[j] = second1.Length;
            var intermediateValue = new int[second.Length + 1];

            intermediateValue[shortLeng] = first[shortLeng - 1];
            for (int i=0;i<shortLeng; i++)
            {
                int elementsSum = first[i] + second1[i] + q; // считает сумму элементов 
                intermediateValue[i] = elementsSum % 10; // то, что запишется в резульат в столбике
                q = elementsSum / 10;//так называемое число в уме
            }
            if (longLeng - shortLeng == 1)
            {
                intermediateValue[0] = q + second1[0] % 10;
                q = q + second1[0] / 10;
            }

            //if (longLeng>shortLeng)
            //    intermediateValue[longLeng - shortLeng] = q + longer[longLeng - shortLeng - 1];
            if (q != 0)
            {
                var result = new int[intermediateValue.Length + 1];
                result[0] = q;
                for (int j = 1; j <= intermediateValue.Length; j++)
                    result[j] = intermediateValue[j - 1];
                Console.WriteLine("Cумма");
                foreach (int e in result)
                    Console.Write(e);
                Console.WriteLine();
                return result;

            }
            else
            {
                Console.WriteLine("Cумма");
                foreach (int e in intermediateValue)
                    Console.Write(e);
                Console.WriteLine();
                return intermediateValue;

            }

        }
        public static string DivideArrayBy2(int[] firstNumber)//Умножает массив на ЧИСЛО
        {
            
            int length = firstNumber.Length-1;
            var intermediateValue = new int[length];// length + 1
            int dividend = 0;
            int residue = 0;
            for (int i = 0; i > length ; i++)
            {
                dividend = firstNumber[i] + residue * 10;
                if (dividend < 2)
                {
                    dividend = dividend * 10 + firstNumber[i + 1];
                    i++;
                }
                int result = dividend / 2; 
                intermediateValue[i] = result;
                residue =dividend % 2 ;
            }
            if (residue != 0)
            {
                string r=intermediateValue.ToString()+",5";
                Console.WriteLine("Деление");
                Console.WriteLine(r);
                return r;
            }
            else
            {
                Console.WriteLine("Деление");
                Console.WriteLine(intermediateValue.ToString());
                return intermediateValue.ToString();
            }
        }

    }
}
