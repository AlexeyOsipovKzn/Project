Console.Clear();
Console.WriteLine("Print 2 numbers");
int x = int.Parse(Console.ReadLine());// преобразование строки число
int y = int.Parse(Console.ReadLine());// преобразование строки число 
if(y*y == x)
{
    Console.WriteLine($"Число {x} является квадратом чила {y}");
}
else 
{
    Console.WriteLine($"Число {x} НЕ является квадратом чила {y}");
}