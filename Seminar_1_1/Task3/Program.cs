﻿// Задача №3. Напишите программу, которая будет 
// выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.WriteLine("Введите номер дня недели: ");
int.TryParse(Console.ReadLine(), out int result);

if (result == 1)
{
    Console.WriteLine($"1 -> понедельник");
}
if (result == 2)
{
    Console.WriteLine($"2 -> вторник");
}
if (result == 3)
{
    Console.WriteLine($"3 -> среда");
}
if (result == 4)
{
    Console.WriteLine($"4 -> четверг");
}
if (result == 5)
{
    Console.WriteLine($"5 -> пятница");
}
if (result == 6)
{
    Console.WriteLine($"6 -> суббота");
}
if (result == 7)
{
    Console.WriteLine($"7 -> воскресенье");
}
