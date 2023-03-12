

int a, b, c;

Console.Write($"Введите число а: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число b: ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write($"Введите число c: ");
int.TryParse(Console.ReadLine()!, out c);

if (a > b && a > c)
    Console.Write($"max = {a} ");
if (b > a && b > c)
    Console.Write($"max = {b} ");
if (c > a && c > a)
    Console.Write($"max = {c} ");
