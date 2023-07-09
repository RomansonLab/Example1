// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {m}, N = {n}, сумма элементов = {sumRange(m, n)}");

int sumRange (int m, int n)
{
    if(m > n)
    {
        return 0;
    }
    return m + sumRange(m + 1, n);
}