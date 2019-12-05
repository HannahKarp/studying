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

            // Console.WriteLine("Prime Numbers : ");
            int status = 0; // 1 -prime number 0 - not prime number
            for (int i = 2; i <= 1000; i++)
            {
                status = 1;
                for (int j = 2; j < i; j++)
                {
                    int result = i % j;
                    if (result == 0)
                    { 
                        status = 0;
                       // Console.WriteLine("not prime number");
                        break;
                    } 
                }
                if (status != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
    
    
