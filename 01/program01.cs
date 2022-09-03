using System;

Console.WriteLine("Введите первое число и нажмите Enter"); 
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число и нажмите Enter");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Первое число больше");
}

else if (number2 > number1)
{
    Console.WriteLine("Второе число больше");
}

else
{
    Console.WriteLine("Числа равны");
}