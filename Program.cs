int N;
int count = 1;

Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);
while (count < N)
{
    if (count < N)
        Console.Write($"{count + 1} ");
    else
        Console.Write($"{count}");
    count += 2;
}