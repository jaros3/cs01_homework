Console.WriteLine("Введите число, которе хотите проверить на четность/нечетность");
/*
string num1 = Console.ReadLine();
var iNum1 = int.Parse(num1);
*/
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($" Чиcло {num} является четным");
}
else
{
    Console.WriteLine($" Число {num} является не четным");
}