// Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то 
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine("Введите число 1  ");
int.TryParse(Console.ReadLine(), out int num1);

Console.WriteLine("Введите число 2  ");
int.TryParse(Console.ReadLine(), out int num2);

// int result = num1 / num2;
int reminder;

Console.WriteLine($"ваши числа {num1} и {num2}");

if (num1 % num2 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    reminder = num1 % num2;
    Console.WriteLine($"не кратно, остаток {reminder}");
}

