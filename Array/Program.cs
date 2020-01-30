using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Input length ");
		int n = int.Parse(Console.ReadLine());

		int[] array1 = new int[n];

		Random rand = new Random();
		for (var i = 0; i < n; i++)
		{
			array1[i] = rand.Next(-100, 101);
		}
		//for (var i = 0; i < n; i++)
		//{
		//	Console.Write(array1[i] + " ");
		//}
		int max = 0;
		int min = 0;
		for (int i = 0; i < array1.Length; i++)
			Console.WriteLine(array1[i] + " ");
		Console.WriteLine();
		for (int i = 0; i < array1.Length; i++)
			if (array1[i] > max)
			{
				max = array1[i];
			}
			else
			{
				if (array1[i] < min)
				{
					min = array1[i];
				}
			}
		Console.WriteLine(min);
		Console.WriteLine(max);
		Console.ReadLine();
	}
}