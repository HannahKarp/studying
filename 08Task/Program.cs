using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 10;
            //for (int i = 2; i <= num; i++)
            //{
                for (int i = 2; i <= 1000; i++)
                {
                    int counter = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                            break;
                        }
                    }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }


            }
                Console.ReadLine();
        }
    }
}
