using System;
					
public class Program
{
	public static void Main()
{
		Console.Clear();
		Console.WriteLine("Print number a");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Print number b");
		int b = int.Parse(Console.ReadLine());
		int min = 0, max = 0;
	if (a > b)
	{
    	max = a;
    	min = b;
	}
	else 
	{
	    max = b;
	    min = a;
	}
		Console.WriteLine($"Max nmuber is = {max} && Min numer is = {min}");
	}
}