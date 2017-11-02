using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Col4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0, 0, 0, 5, 6, 7, 8, 9,10 ,0,0,0,9,8};// Нам ведь дан массив, вот я его и написала
            var subarray = new int[m];// подмассив
            int sum = 0;
            for (int i = 0; i < m; i++)//нахождение суммы
                sum += array[i];
            int a = 0;
            int indexOfMaxSum = 0;//еслиприбавить к этой переменной 1, то это будет первый индекс подмассива (Со следующего элемента начинается подмассив)
            int maxSum = sum;
            for (int j = m; j < array.Length; j++)
            {
                sum = sum + array[j] - array[a];
                if (sum>maxSum)
                {
                    maxSum = sum;
                    indexOfMaxSum = a;
                }
                a++;
            }
            int n = 0;
            for (int k = indexOfMaxSum+1; k <= indexOfMaxSum + m; k++)
            {
                subarray[n] = array[k];
                n++;
            }
            foreach (int e in subarray)
                Console.WriteLine(e);
        }
    }
}
