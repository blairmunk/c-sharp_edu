﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Input number 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// {
//     Console.WriteLine($"max = {num1}. {num1} is greater then {num2}");
// }
// else
// {
//     Console.WriteLine($"max = {num2}. {num2} is greater then {num1}");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7; 44 5 78 -> 78; 22 3 9 -> 22

// Console.WriteLine("Input three numbers: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     if (num1 > num3) Console.WriteLine($"Max number is {num1}.");
//     else Console.WriteLine($"Max number is {num3}.");
// }
// else
// {
//     if (num2 > num3) Console.WriteLine($"Max number is {num2}.");
//     else Console.WriteLine($"Max number is {num3}.");
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да; -3 -> нет; 7 -> нет

// Console.WriteLine("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine($"{num} IS even.");
// }
// else 
//     Console.WriteLine($"{num} is NOT even.");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4; 8 -> 2, 4, 6, 8

// Способ 1:
// Console.Write("Input a number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int num = 2;

// while (num <= N)
// {
//     Console.Write($"{num} ");
//     num += 2;
// }
// Console.WriteLine();

// Способ 2:
Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int num = 2;

while (num <= N)
{
    if (num % 2 == 0) Console.Write($"{num} ");
    num += 1;
}
Console.WriteLine();
