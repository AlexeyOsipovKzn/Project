using System;
					
public class Program
{
	public static void Main()
{
		Console.Clear();
		Console.WriteLine("Print number");
		int a = int.Parse(Console.ReadLine());
	if(a % 2 == 0)
  {
    Console.WriteLine($"The number {a} is even");
  }
    else 
    {
       Console.WriteLine($"The number {a} is not even");
    }
	}
  
}