using System;

namespace SumOfNumbers
{
    class Program
    {
        public static int SumOfNumbers(int input)
        {
            int sum = 0;
            int i = input;
            while (i > 0)
            {
                sum = sum + i % 10;
                i = i / 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int number = Convert.ToInt16(Console.ReadLine());
            number = SumOfNumbers(number);
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
