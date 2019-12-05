using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Maximum value is: " + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("Minimum value is: " + Math.Min(a, Math.Min(b, c)));
            Console.ReadLine();

        }
    }
}
