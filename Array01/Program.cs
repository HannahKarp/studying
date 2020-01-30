using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array01
{
	class Array_02
	{
		public static void Main()
		{
			Console.WriteLine("Input length ");
			int n = int.Parse(Console.ReadLine());

			int[] array1 = new int[n];

			Random rand = new Random();
			for (var i = 0; i < n; i++)
			{
				array1[i] = rand.Next(1, 10);
				Console.WriteLine(array1[i] + " ");
			}
			int sum = 0;
			for (int i = 0; i < n; i++)
			{
				sum = sum + array1[i];
			}
			int productd = 1;
			for (int i = 0; i < n; i++)
			{
				productd = productd * array1[i];
			}
			Console.WriteLine("sum = " + sum);
			Console.WriteLine("productd = " + productd);
			Console.ReadLine();
		}
	}
}
