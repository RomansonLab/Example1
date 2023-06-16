// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int insert = Prompt("Введите пятизначное число: ");
if (insert > 9999)
{
    FindPolyndronome(insert);
}
else
{
    Console.WriteLine("Вы ввели НЕ пятизначное число");
}


void FindPolyndronome(int allnumber)
{
    int num1 = allnumber / 10000;
    int num2 = allnumber / 1000 %10;
    int num3 = allnumber / 100 %10;
    int num4 = allnumber / 10 %10;
    int num5 = allnumber / 1 %10;

    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"{allnumber} -> да, палиндроном");
    }
    else
    {
        Console.WriteLine($"{allnumber} -> нет, не палиндроном");
    }
}

// Console.WriteLine($"{num1}, {num2}, {num3}, {num4}, {num5}");


