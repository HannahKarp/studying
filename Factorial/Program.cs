using System;

namespace Factorial
{
    class Program
    {
        public static int Factorial(int input)
        {
            int factorial = 1;
            for (int i = 1; i < input; i++)
            {
                factorial = (i + 1) * factorial;
            }
            return factorial;
        }
  

        static void Main(string[] args)
        {
            int number;
            Console.Write("number of factorial = ");
            number = Convert.ToInt32(Console.ReadLine());
            number = Factorial(number);
            Console.WriteLine(number);
            Console.ReadLine();
        }
        
    }
}
