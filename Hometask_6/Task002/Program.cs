// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Формула решения:
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

Console.WriteLine("Введите значения для первой прямой:");
int k1 = Prompt("Введите значение k1: ");
int b1 = Prompt("Введите значение b1: ");
Console.WriteLine("Введите значения для второй прямой:");
int k2 = Prompt("Введите значение k2: ");
int b2 = Prompt("Введите значение b2: ");
findXY(args);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


void findXY(string[] args)
{
    if (k1 == k2)
    {
       Console.WriteLine("Прямые параллельны, точки пересечения нет.");
    }
    else
    {
        double x = (double)(b2 - b1) / (double)(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
    }
}