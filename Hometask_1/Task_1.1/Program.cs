// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число  ");
int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("Введите второе число  ");
int.TryParse(Console.ReadLine(), out int b);

int max = a;

if (a >= b)
{
    max = a;
    Console.WriteLine($" a = {a}; b = {b} -> max = {max}");
}
else
{
    max = b;
    Console.WriteLine($" a = {a}; b = {b} -> max = {max}");
}