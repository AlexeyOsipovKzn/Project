using System;
					
public class Program
{
	public static void Main()
{
		Console.Clear();
		Console.WriteLine("Print number");
		int a = int.Parse(Console.ReadLine());
    Console.WriteLine("1 to N  numbers");
	 for(int i = 1; i < a ; i++)
   {
     if( i % 2 == 0)
     {
       Console.Write($"  {i} ,");
     }
   }
	}
  
}
