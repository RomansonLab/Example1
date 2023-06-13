// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int.TryParse(Console.ReadLine(), out int num1);
int result;

if (num1 < 100 | num1 > 999)
{
    Console.WriteLine("Тебе же сказали ввести ТРЕХзначное число, а ты что ввел?");
}
else
{
    result = num1 / 10;
    result = result % 10;
    Console.WriteLine($"{num1}, вторая цифра -> {result}");
}

