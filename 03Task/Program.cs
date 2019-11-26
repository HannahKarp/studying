using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentYear = Convert.ToInt16(DateTime.Now.Year);
            Console.WriteLine("Current year = {0}", currentYear);  
            int age = Convert.ToInt16(Console.ReadLine());
           // Console.WriteLine("Birthday year = {0}", age);
            int result = currentYear - age;
            Console.WriteLine(result);
            // DateTime.Now;
            Console.ReadLine();
        }
        

    }
}
