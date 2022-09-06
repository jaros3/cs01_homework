// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
    
Console.WriteLine("Введите  второе число: ");
 int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите  второе число: ");
 int numberC = int.Parse(Console.ReadLine());
 
 int max = 0;
if(numberA > numberB && numberA > numberC)
{
    max = numberA;    
}
else if(numberB > numberA && numberB > numberC)
{
    max = numberB;
}
else max = numberC;

Console.WriteLine(max);*/

// вариант с функцией

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
    
Console.WriteLine("Введите  второе число: ");
 int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите  второе число: ");
 int numberC = int.Parse(Console.ReadLine());
 
 int max = 0;

max = Math.Max(numberA, Math.Max(numberB, numberC));

Console.WriteLine(max);
