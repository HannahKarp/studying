using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt16(Console.ReadLine());
            if (num > 0)
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine($"even numbers = " + i);
                    else
                        Console.WriteLine($"odd numbers = " + i);
                }
            else
                Console.WriteLine("specified number < = 1");
            Console.ReadLine();


        }
    }
}
