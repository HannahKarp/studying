using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 4, -1, 2, 5, 10, 7, 8, 9, -10 };
            int max = 0;
            int min = 0;
            for (int i = 0; i < array1.Length; i++)
                Console.WriteLine(array1[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < array1.Length; i++)
                if (array1[i] > max)
                {
                    max = array1[i];
                }
                else
                {
                    if (array1[i] < min)
                    {
                        min = array1[i];
                    }
                }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
