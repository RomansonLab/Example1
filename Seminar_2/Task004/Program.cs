// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23

Console.Clear();
Console.WriteLine("Введите число 1  ");
int.TryParse(Console.ReadLine(), out int num1);

if (num1 % 7 == 0)
{
    if (num1 % 23 == 0)
    {
        Console.WriteLine($"число {num1} кратно и 7 и 23");
    }
    
}
else
{
    Console.WriteLine($"число {num1} НЕ кратно и 7 и 23");
}