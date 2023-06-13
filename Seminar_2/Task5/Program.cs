// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();
Console.WriteLine("Введите число 1  ");
int.TryParse(Console.ReadLine(), out int num1);

Console.WriteLine("Введите число 2  ");
int.TryParse(Console.ReadLine(), out int num2);

if (num1*num1 == num2 | num2*num2 == num1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
