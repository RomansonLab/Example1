// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.Write("Введите количество строк 1-ой матрицы: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1-ой матрицы: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент 1-ой матрицы: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент 1-ой матрицы: ");
int maxValue = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк 2-ой матрицы: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2-ой матрицы: ");
int columns2 = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент 2-ой матрицы: ");
int minValue2 = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент 2-ой матрицы: ");
int maxValue2 = int.Parse(Console.ReadLine());

int[,] array1 = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine();
Console.WriteLine("1-ая матрица: ");
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(rows2, columns2, minValue2, maxValue2);
Console.WriteLine();
Console.WriteLine("2-ая матрица: ");
PrintArray(array2);
Console.WriteLine();
int[,] resultMatrix = MultiplyMatrixes(array1, array2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица: ");
PrintArray(resultMatrix);


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

int[,] MultiplyMatrixes(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int columns2 = matrix2.GetLength(1);

    int[,] result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;
            for (int k = 0; k < columns1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
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

