
int a;
Console.Write($"Введите число а: ");
int.TryParse(Console.ReadLine()!, out a);

if (a % 2 == 0)
    Console.Write($" -> да ");
else
    Console.Write($" -> нет ");
