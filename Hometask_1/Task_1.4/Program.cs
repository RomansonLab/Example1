// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число  ");
int.TryParse(Console.ReadLine(), out int a);
int i = 1;

while (i <= a)
{
    int result = i % 2;
    if (result == 0)
    {
        Console.Write(i + " ");
    }
    else
    {
        
    }
    i++;
}
