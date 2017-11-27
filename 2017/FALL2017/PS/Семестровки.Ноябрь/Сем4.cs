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
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число к");
            double k = double.Parse(Console.ReadLine());
            SumOfProgression(TranslateIntoAnArray(n),n,k);
        }
        public static double[] SumOfProgression(double[] arrayN,double n ,double k)
        {
            arrayN[arrayN.Length-1] /= 2;
            var sum = new double[0];
            for (int i = arrayN.Length; i > 0; i-- )
            {
                var intermediateValue = Multiply(GetLastElement(TranslateIntoAnArray(n),k), i);
                sum = AddUp(sum, intermediateValue);
            }
            return sum;  
        }
        public static double[] GetLastElement(double[] n, double k)
        {
            var difference=new double[0];
            for (int i = n.Length; i > 0; i--)
            {
               var intermediateValue = Multiply(TranslateIntoAnArray(k), i);
                difference = AddUp(difference, intermediateValue);   
            }
            difference[difference.Length] += 2*1; // прибавляю 1 так как первый элемент в Данной последовательности всегда 
            return difference;            // дальше в программе понадобиться прибавить первый элемент ещё раз, а я это сделаю сейчас
        }

        public static double[] TranslateIntoAnArray(double number)//переводит число в массив
        {
            var listOfNumber = new List<double>();
            while (number % 10 > 0)
            {
                listOfNumber.Add(number/ 10);
                number = number / 10;
            }
            listOfNumber.Reverse();
            var arrayOfNumber=new double[listOfNumber.Count];
            int i = 0;
            foreach (var t in listOfNumber)
            {
                arrayOfNumber[i] = t;
                i++;
            }
            return arrayOfNumber;
        }

        public static double[] Multiply(double[] firstNumber, double k)//Умножает массив на число
        {
            double q = 0;
            int length = firstNumber.Length;
            var intermediateValue = new double[length + 1];
            for (int i=length; i>0 ; i--)  
                {
                    intermediateValue[i] = (firstNumber[i] * k + q) % 10;
                    q = (firstNumber[i] * k + q) / 10;
                }
             intermediateValue[0] = q;
            return intermediateValue;
        }

        public static double[] AddUp(double[] firstNumber, double[] secondNumber)//Суммирует два числа(массива)
        {
            double q = 0;
            int length = Math.Max(firstNumber.Length,secondNumber.Length);
            var intermediateValue = new double[length+1];
            
            for (int i = length; i > 0; i--)
            {
                intermediateValue[i] = (firstNumber[i] + secondNumber[i] + q) % 10;
                q = (firstNumber[i] + secondNumber[i] + q) / 10;
            }
            intermediateValue[0] = q;
            return intermediateValue;
        }
    
    }
}
