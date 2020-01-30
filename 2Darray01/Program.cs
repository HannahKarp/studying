using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray01
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = 3;
            int m = 4;
            int[,] mas2 = new int[n, m];
            Random ran = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas2[i, j] = ran.Next(20);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mas2[i, j] + " ");
                }
                Console.Write("\n");
            }
            int MaxrowSum = 0;

            for (int i = 0; i < n; i++)
            {
                int rowSum = 0;      
                for (int j = 0; j < m; j++)
                {
                    rowSum += mas2[i, j];
                }
                if (rowSum > MaxrowSum) MaxrowSum = rowSum;  
            }

            int MincolmSum = 0;

            for (int i = 0; i < m; i++)
            {
                int colmSum = mas2[0, i];
                //int columnSum = mas2[0, i]; //0;      
                for (int j = 1; j < n; j++)
                {
                    if (mas2[j, i] < colmSum)
                    {
                        colmSum = mas2[j, i];
                        colmSum = MincolmSum;
                    }
                }
               
            }
            Console.WriteLine("Max rom sum = "+ MaxrowSum);
            Console.WriteLine("Min column sum = " + MincolmSum);
            Console.ReadLine();
        }
    }
}
