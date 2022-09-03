Console.WriteLine("Введите любое целочисленное число и нажмите Enter");

int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Вот какие четные числа находятся в диапазоне от 1 до {num}:");

for (int i = 2; i <= num; i += 2)
{
    Console.Write($"{i} ");
}