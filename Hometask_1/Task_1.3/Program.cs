﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число  ");
int.TryParse(Console.ReadLine(), out int a);

int result = a % 2;

if (result == 0)
{
    Console.WriteLine($" {a} -> четное");
}
else
{
    Console.WriteLine($" {a} -> нечетное");
}
