// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


int rows = Prompt("Введите колличество строк: ");
int columns = Prompt("Введите колличество столбцов: ");
int minValue = Prompt("Введите число для минимального диапазона значений: ");
int maxValue = Prompt("Введите число для максимального диапазона значений: ");

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
PrintArray(SearchEven(array));



int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max); // [0,0] , [0,1] , [0,2]....//[1,0], [1,1] , [1,2]

        }
    }
    return result;
}

int[,] SearchEven(int[,] arr)
{
    for( int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if ( i % 2 == 0 && j % 2 == 0)
            {
                // arr[i, j] *= 2;
                arr[i, j] = arr[i, j] * arr[i, j];
                
            }
             
        }
       
    }
    return arr;

}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) // GetLength(0) - длина строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) // GetLength(1) - длина столбцов
        {
            Console.Write(arr[i, j] + " ");

        }
        Console.WriteLine();
    }
}