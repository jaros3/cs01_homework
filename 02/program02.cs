Console.WriteLine("Введите три числа для нахождения максимального из них");

int iNum1 = int.Parse(Console.ReadLine());
int iNum2 = int.Parse(Console.ReadLine());
int iNum3 = int.Parse(Console.ReadLine());

int max = iNum1;

if (max < iNum2)
{
    max = iNum2;
}
if (max < iNum3)
{
    max = iNum3;
}
Console.WriteLine($"{max} данное число является самым большим");