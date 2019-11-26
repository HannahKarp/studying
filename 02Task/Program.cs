using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Task
{
    class Program
    {
        static void Main(string[] args)
        {
          
            float h = 0.5f;

            for (float x = -10; x <= 10; x+=h)
            {
                float y = x * x + x - (80 / x);
                Console.WriteLine(y);
            }
       
        }
    }
}
