using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Task
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
            double perimeter = a + b + c;
            Console.WriteLine("perimeter = {0}", perimeter);
            Console.Write("height = ");
            double height = Convert.ToDouble(Console.ReadLine());
            //double area;
            Console.WriteLine("area = {0}", (b * height) / 2);
            Console.ReadLine();
        }
    }
}
