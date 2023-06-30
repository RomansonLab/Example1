// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int rows = Prompt("Введите количество строк");
int columns = Prompt("Введите количество столбцов");
double minValue = Prompt("Введите число для мин диапазона");
double maxValue = Prompt("Введите число для макс диапазона");

double[,] array = GetArray(rows, columns, minValue, maxValue); 
Console.WriteLine("Исходный массив:");
PrintArray(array);

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] GetArray(int m, int n, double min, double max)
{
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble() * (max - min) + min;
            Console.Write($"{result[i,j]} ");
        }
        Console.WriteLine();
    }
    return result;
}

void PrintArray(double[,] arr)
{
      for(int i = 0; i < arr.GetLength(0); i++)  // длина строки
    {
        for(int j = 0; j < arr.GetLength(1); j++)  // длина столбца
        {
            Console.Write(arr[i,j].ToString("F1") + " ");
         
        }
        Console.WriteLine();
    }
}
