// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxValue = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine();
Console.WriteLine("Изначальный массив: ");
PrintArray(array);
Console.WriteLine();

int rowWithMinimumSum = FindRowWithMinimumSum(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {rowWithMinimumSum + 1}");



int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int FindRowWithMinimumSum(int[,] inArray)
{
    int minSum = int.MaxValue;
    int rowWithMinSum = -1;

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            rowSum += inArray[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            rowWithMinSum = i;
        }
    }

    return rowWithMinSum;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {

            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

