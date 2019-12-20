using System;

namespace EvenOddNumbers
{
    class Program
    {
        public static int EvenOddNumbers(int input)
        {
            int number = 1;
            if (number > 0)
                for (int i = 1; i <= input; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine($"even numbers = " + i);
                    else
                        Console.WriteLine($"odd numbers = " + i);
                }
            else
                Console.WriteLine("specified number < = 1");
            return number;
        }
        static void Main(string[] args)
        {
            int number;
            Console.Write("specified number = ");
            number = Convert.ToInt32(Console.ReadLine());
            number = EvenOddNumbers(number);
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
