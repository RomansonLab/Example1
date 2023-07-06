// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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


int[,] newArray = GetNewArray(rows, columns, minValue, maxValue);
Console.WriteLine();
Console.WriteLine("Результирующий массив: ");
PrintArray(newArray);


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

int[,] GetNewArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    int value = 1;
    int rowStart = 0;
    int rowEnd = m - 1;
    int columnStart = 0;
    int columnEnd = n - 1;

    while (rowStart <= rowEnd && columnStart <= columnEnd)
    {
        // Заполнение верхней строки
        for (int i = columnStart; i <= columnEnd; i++)
        {
            result[rowStart, i] = value++;
        }
        rowStart++;

        // Заполнение последнего столбца
        for (int i = rowStart; i <= rowEnd; i++)
        {
            result[i, columnEnd] = value++;
        }
        columnEnd--;

        // Заполнение нижней строки
        if (rowStart <= rowEnd)
        {
            for (int i = columnEnd; i >= columnStart; i--)
            {
                result[rowEnd, i] = value++;
            }
            rowEnd--;
        }

        // Заполнение первого столбца
        if (columnStart <= columnEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                result[i, columnStart] = value++;
            }
            columnStart++;
        }
    }

    return result;
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

