// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число  ");
int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("Введите второе число  ");
int.TryParse(Console.ReadLine(), out int b);

Console.WriteLine("Введите третье число  ");
int.TryParse(Console.ReadLine(), out int c);

int max = a;

if (a >= b)
{
    if (a >= c)
    {
        max = a;
        Console.WriteLine($" a = {a}; b = {b}; c = {c} -> max = {max}");
    }
    else
    {
        max = c;
        Console.WriteLine($" a = {a}; b = {b}; c = {c} -> max = {max}");
    }
}
else
{
    if (b >= c)
    {
        max = b;
        Console.WriteLine($" a = {a}; b = {b}; c = {c} -> max = {max}");
    }
    else
    {
        max = c;
        Console.WriteLine($" a = {a}; b = {b}; c = {c} -> max = {max}");
    }

}