// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int X = Prompt("Введите координату Х: ");
int Y = Prompt("Введите координату Y: ");
FindQuater(X,Y);
// Console.WriteLine(x + "  " + y);


void FindQuater(int x, int y)
{
    if(x > 0 && y > 0)
    {
        Console.WriteLine("I четверть");
    }
    else if(x<0 && y > 0)
    {
        Console.WriteLine("II четверть");
    }
    else if(x<0 && y < 0)
    {
        Console.WriteLine("III четверть");
    }
    else if(x>0 && y < 0)
    {
        Console.WriteLine("IV четверть");
    }
    else
    {
        Console.WriteLine("Это ошибка");
    }
}