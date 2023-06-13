// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру, соответствующую дню недели. От 1 до 7");
int.TryParse(Console.ReadLine(), out int num1);

if (num1 >= 1 & num1 <= 5)
{
    Console.WriteLine($"{num1} -> нет, рабочий день");
}
else if (num1 < 1 | num1 > 7)
{
    Console.WriteLine($"{num1} -> вы ввели неверный день недели");
}
else
{
    Console.WriteLine($"{num1} -> да, выходной");
}