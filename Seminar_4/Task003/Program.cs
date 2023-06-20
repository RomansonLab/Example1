// Задача 28: Напишите программу, которая 
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int N = Prompt("Введите число:  ");
int result = ProductNum(N);
Console.WriteLine(result);

int ProductNum(int N)
{
    int product = 1;
    for (int i=0; i <= N; i++)
    {
        product = product * i;
    }
    return product;
}