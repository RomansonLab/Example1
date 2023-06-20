// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int userNum = Prompt("Введите число:  ");
int result = CountNum(userNum);
Console.WriteLine(result);

int CountNum(int userNum)
{
    int i = 0;

    while(userNum >= 1)
    {
        userNum = userNum / 10; 
        i++;

    } 
    return i;
}