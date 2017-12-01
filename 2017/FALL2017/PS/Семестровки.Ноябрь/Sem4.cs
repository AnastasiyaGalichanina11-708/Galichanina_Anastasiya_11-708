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
            arrayN[arrayN.Length - 1] -= 1;
            return arrayN;
        }
        public static void SumOfProgression(int n, int k)
        {
            var arrayN = TranslateIntoAnArray(n);
            var arrayK = TranslateIntoAnArray(k);
            int[] c = GetLastElement(Subtraction(arrayN), arrayK);   //(n-1)d
            c[c.Length - 1] += 2;  // 2a+d(n-1)
            if (c[c.Length - 1] + 2 > 9)
                c[c.Length - 2] += 1;
            int[] t=

            
            //var sum = new int[1];
            //sum[0] = 0;
            //for (int i = arrayN.Length; i >= 0; i--)
            //{
                var intermediateValue = Multiply(, i);
            //sum = AddUp(sum, intermediateValue);
            //}
            Console.WriteLine("КОНЧЕННАЯ Cумма");
            foreach (int e in sum)
                Console.Write(e);
            
        }
        public static int[] MultiplyArrayByArray(int[] n, int[] k)// высчитывает d(n-1) // умножает массив на МАССИВ
        {
            var difference = new int[1];
            difference[0] = 0;
            for (int i = k.Length; i > 0; i--)
            {
                var intermediateValue = MultiplyArrayByNumber(n, k[i-1]);
                difference = AddUp(difference, intermediateValue);
            }
            Console.WriteLine("разница");
            foreach (int e in difference)
                Console.Write(e);
            Console.WriteLine();
            return difference;            // дальше в программе понадобиться прибавить первый элемент ещё раз, а я это сделаю сейчас
        }

        public static int[] TranslateIntoAnArray(int number)//переводит число в массив
        {
            var listOfNumber = new List<int>();
            while (number % 10 > 0)
            {
                listOfNumber.Add(number % 10);
                number =  number / 10;
            }
            listOfNumber.Reverse();
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
            var intermediateValue = new int[length];// length + 1
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

        public static int[] AddUp(int[] shorter, int[] longer)//Суммирует два числа () при умножении в столбике 
        {
            int q = 0;
            int shortLeng = shorter.Length;
            int longLeng = longer.Length;
            var intermediateValue = new int[shortLeng + 1];
            
            intermediateValue[shortLeng] = shorter[shortLeng - 1];
            int i = 0;
            while (i < shortLeng-1)
            {
                int elementsSum = shorter[shortLeng - 2 - i] + longer[longLeng - 1 - i] + q; // считает сумму элементов 
                intermediateValue[shortLeng- 1 -i] = elementsSum % 10; // то, что запишется в резульат в столбике
                q = elementsSum/ 10;//так называемое число в уме
                i += 1;
            }
            if (longLeng - shortLeng == 1)
            {
                intermediateValue[0] = q + longer[0] % 10;
                q = q + longer[0] / 10;
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

    }
}
