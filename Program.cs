

int a, b;
Console.Write($"Введите число а: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число b: ");
int.TryParse(Console.ReadLine()!, out b);

if (b > a)
    Console.Write($"max = {b} ");
else
    Console.Write($"min = ");


