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
             
            var sum = new int[0];
            for (int i = arrayN.Length-1; i >= 0; i--)
            {
                var intermediateValue = Multiply(GetLastElement(arrayN, k), i);
                sum = AddUp(sum, intermediateValue);
            }
            Console.WriteLine("КОНЧЕННАЯ Cумма");
            foreach (int e in sum)
                Console.Write(e);
            
        }
        public static int[] GetLastElement(int[] n, int[] k)// высчитывает d(n-1)
        {
            var difference = new int[0];
            for (int i = k.Length; i > 0; i--)
            {
                var intermediateValue = Multiply(n, k[i-1]);
                difference = AddUp(difference, intermediateValue);
            }
            difference[difference.Length-1] += 2 * 1; // прибавляю 1 так как первый элемент в Данной последовательности всегда 
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

        public static int[] Multiply(int[] firstNumber, int k)//Умножает массив на число
        {
            int q = 0;
            int length = firstNumber.Length;
            var intermediateValue = new int[length + 1];
            for (int i = length; i > 0; i--)
            {
                intermediateValue[i] = (firstNumber[i-1] * k + q) % 10;
                q = (firstNumber[i-1] * k + q) / 10;
            }
            intermediateValue[0] = q;
            Console.WriteLine("Умножение");
            foreach (int e in intermediateValue)
                Console.Write(e);
            Console.WriteLine();
            return intermediateValue;

        }

        public static int[] AddUp(int[] shorter, int[] longer)//Суммирует два числа(массива)
        {
            int q = 0;
            int shortLeng = shorter.Length;// Да, я знаю, что переменные надо какими-то осмысленными названиями делать,
            int longLeng = longer.Length;// но ведь когда мы делаем обозначение чисел(слагаемых) в формуле a,b
            var intermediateValue = new int[shortLeng + 2];
            var result = new List<int>();
            intermediateValue[shortLeng + 1] = shorter[shortLeng - 1];
            for (int i = shortLeng-1; i >= 0; i--)
            {
                if (i > shortLeng)
                {
                    intermediateValue[i] = (shorter[i - 2] + longer[i - 1] + q) % 10;
                    q = (shorter[i - 1] + longer[i - 1] + q) / 10;
                }
                if (shortLeng > longLeng)
                    intermediateValue[i] = shorter[i-1];
                
                else
                    intermediateValue[i] = longer[i - 1];
            }
            if (shortLeng > longLeng)
               intermediateValue[longLeng-shortLeng] = q + shorter[longLeng - shortLeng - 1];
            if (longLeng>shortLeng)
                intermediateValue[longLeng - shortLeng] = q + longer[longLeng - shortLeng - 1];
            if (intermediateValue[0] == 0)
                for (int j = 1; j < intermediateValue.Length; j++) 
                    result.Add(intermediateValue[j]);

            Console.WriteLine("Cумма");
            foreach (int e in result)
                Console.Write(e);
            Console.WriteLine();
            return result.ToArray();
        }

    }
}
