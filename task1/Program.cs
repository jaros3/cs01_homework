//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//вывод максимального числа
/*
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
    
Console.WriteLine("Введите  второе число: ");
 int numberB = int.Parse(Console.ReadLine());

int max = numberA;
if (numberA > numberB)
    Console.WriteLine(max);
    
else{
    Console.WriteLine(max = numberB);
}*/

//2й вариант
/*
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
    
Console.WriteLine("Введите  второе число: ");
 int numberB = int.Parse(Console.ReadLine());

if(numberA > numberB)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (numberA < numberB)
            {
                Console.WriteLine("Первое число меньше второго");
            }
            else
            {
                Console.WriteLine("Оба числа равны");
            }
*/
// с использованием функции

void MaxMinNumber (int numberA, int numberB) 
{
    int min = 0; 
    int max = 0;
    if (numberA > numberB)
    {
        max = numberA; min = numberB;
    }
    else if (numberB > numberA)
    {
        max = numberB; min = numberA;
    }
    Console.WriteLine($"В данной паре чисел {max} - большее, а {min} - меньшее.");
}


