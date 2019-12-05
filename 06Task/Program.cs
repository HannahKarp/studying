using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = Convert.ToInt16(Console.ReadLine());
            //while (i != 0)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            int num = Convert.ToInt16(Console.ReadLine());
            int sum = 0;
            //for (int i = num; i>0; i--)
            //{
            //    sum = sum + i % 10;
            //    i = (i / 10) + 1;
            //}
            int i = num;
            while (i > 0)
            {
                sum = sum + i % 10;
                i = i / 10;

            }
            Console.WriteLine(sum);
                Console.ReadLine();
        }
    }
}
