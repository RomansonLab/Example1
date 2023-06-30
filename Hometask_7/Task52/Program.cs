// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое первого столбца: 7,0; 
// Среднее арифметическое второго столбца: 8,5;
// Среднее арифметическое третьего столбца: 5,5;
// Среднее арифметическое четвертого столбца: 4,5;

int rows = Prompt("Введите количество строк");
int columns = Prompt("Введите количество столбцов");
int minValue = Prompt("Введите число для мин диапазона");
int maxValue = Prompt("Введите число для макс диапазона");

Console.WriteLine();
Console.WriteLine("Заданный массив: ");
int[,] array = GetArray(rows, columns, minValue, maxValue); 

Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
averageByColumn(array);

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min, max);
            Console.Write($"{result[i,j]} ");
        }
        Console.WriteLine();
    }
    return result;
}

void averageByColumn(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    
    for(int j = 0; j < columns; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        double average = (double)sum / rows;
        Console.WriteLine($"Среднее арифметическое {j + 1}-го столбца: {average:F1}");
    }

}

void PrintArray(int[,] arr)
{
      for(int i = 0; i < arr.GetLength(0); i++)  // длина строки
    {
        for(int j = 0; j < arr.GetLength(1); j++)  // длина столбца
        {
            Console.Write(arr[i,j] + " ");
         
        }
        Console.WriteLine();
    }
}
