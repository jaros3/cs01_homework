//  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//  является ли число чётным (делится ли оно на два без остатка).
// 4 → да
// −3 → нет
// 0 → да

using System;

Console.WriteLine("Введите число");
string input = Console.ReadLine();

int number = int.Parse(input);

if (number % 2 == 0)
    System.Console.WriteLine($"число {number} четное");
else
    System.Console.WriteLine($"число {number} нечетное");

