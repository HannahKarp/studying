using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial;
            Console.Write("number of factorial = "); 
            factorial = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = factorial; i > 1; i--)
            //{
            //    result = result * i;  
            //}
            int result2 = 1;
            for (int j = 1; j < factorial ; j++)
            {
                result2 = (j+1)*result2;
            }
          //  Console.WriteLine("result = " + result);
            Console.WriteLine("result = " + result2);
            Console.ReadLine();
        }
    }
}
