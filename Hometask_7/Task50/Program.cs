// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int rows = Prompt("Введите количество строк");
int columns = Prompt("Введите количество столбцов");
int minValue = Prompt("Введите число для мин диапазона");
int maxValue = Prompt("Введите число для макс диапазона");
int x = Prompt("Введите x-координату (столбец) элемента ");
int y = Prompt("Введите у-координату (строку) элемента ");

int[,] array = GetArray(rows, columns, minValue, maxValue); 
Console.WriteLine("Изначальный массив");
PrintArray(array);
int element = findElement(array, x, y);
    if (element != -1)
    {
         Console.WriteLine($"Значение элемента на позиции ({x}, {y}): {element}");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует.");
    }



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

int findElement(int[,] arr, int x, int y)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    
    if (x >= 0 && x < rows && y >= 0 && y < columns)
    {
        return arr[x, y];
    }
    else
    {
        return -1;
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
