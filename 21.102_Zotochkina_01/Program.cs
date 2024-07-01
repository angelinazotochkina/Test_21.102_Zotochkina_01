using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._102_Zotochkina_01
{
 public class Program
    {
       public static int NMin(double[] A, int N)
        {
            double min = A[0];
            int minIndex = 0;

            for (int i = 1; i < N; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

     public   static int NMax(double[] A, int N)
        {
            double max = A[0];
            int maxIndex = 0;

            for (int i = 1; i < N; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

     public   static void Main()
        {
            double[] array = { 3.14, 2.71, 1.618, 0.0, 42.0 }; // пример массива

            int minIndex = NMin(array, array.Length);
            int maxIndex = NMax(array, array.Length);

            Console.WriteLine("Индекс минимального элемента: " + minIndex);
            Console.WriteLine("Индекс максимального элемента: " + maxIndex);
        }
    }
}
