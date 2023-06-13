
// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int num1);
int result;

if (num1 < 100)
{
    Console.WriteLine("Третей цифры нет");
}
else
{
    while(num1 / 10 > 99)
    {
        num1 = num1 / 10;
    }
    result = num1 % 10;
    Console.WriteLine(result);
    
}