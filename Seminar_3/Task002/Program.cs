// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int num = Prompt("Введите номер четверти: ");
FindCoordinates(num);

void FindCoordinates(int quarter)
{
    string result = "";
    if (quarter == 1)
    {
        result = "Х и У положительны";
    }
    else if (quarter == 2)
    {
        result = "Х -положит и У отрицат";
    }
    else if (quarter == 3)
    {
        result = "Х -отриц и У отрицат";
    }
    else if (quarter == 4)
    {
        result = "Х -отрицат и У положит";
    }
    else 
    {
        result = "Ошибка";
    }
    Console.WriteLine(result);
}