using System;

namespace EvenOddNumbers
{
    class Program
    {
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }

            return false;
        }
        public static void PrintEvenOddNumbers(int maxNumber)
        {
            if (maxNumber > 0)
            {
                for (int i = 1; i <= maxNumber; i++)
                {
                    bool isEven = IsEven(i);

                    if (isEven)
                    {
                        Console.WriteLine(i + " even");
                    }
                    else
                    {
                        Console.WriteLine(i + " odd");
                    }
                }
            }
            else
            {
                Console.WriteLine("specified number < = 1");
            }
        }

        static void Main(string[] args)
        {
            int number;
            Console.Write("specified number = ");
            number = Convert.ToInt32(Console.ReadLine());
             PrintEvenOddNumbers(number);
            Console.ReadLine();
        }
    }
}
