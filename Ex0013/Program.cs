using System;

class Program {
    static void Main() {
      Console.WriteLine("-_-_-_Поиск числа Палиндрома-_-_-_");
      Console.WriteLine();
      Console.Write("\t  Введите число :  ");
      Console.WriteLine("");
      int num = int.Parse(Console.ReadLine());
      Console.WriteLine($"\tВы ввели число  : {num}");
      Console.WriteLine();
      if(num < 0) num = -num; 
      int number = num;
      int revers = 0;
      int tmp = 0;
      int len = (int)Math.Log10(num) + 1;
      Console.WriteLine("\t Процесс реверса");
      Console.WriteLine();
      for(int i = 1; i <= len; i++)
        {
          tmp = num % 10;
          num = num / 10;
          revers = revers * 10 + tmp;
        Console.WriteLine(revers);
        Console.WriteLine();
        }
        if(number == revers)
        {
          Console.WriteLine($"\t Число {number} Палиндром");
        }
        else
        {
          Console.WriteLine($"\t Число {number} Не Палиндром");  
        }
  
    }
}