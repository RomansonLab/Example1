// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = Prompt("введите число N:  ");
Kyb(number);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Kyb(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.Write(i*i*i + " ");
        i++;
    }
}