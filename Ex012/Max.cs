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
    Console.WriteLine("Print number c");
		int c = int.Parse(Console.ReadLine());
		int  max = a;
	if(b > max)
	{
    	max = b;
	}
	  else if(c > max)
  	{
	    max = c;
	  }
      else 
      {
       max = max; 
      }
		Console.WriteLine($"Max nmuber is = {max}");
	}
}