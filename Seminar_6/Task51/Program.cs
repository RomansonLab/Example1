// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int rows = Prompt("Введите колличество строк: ");
int columns = Prompt("Введите колличество столбцов: ");
int minValue = Prompt("Введите число для минимального диапазона значений: ");
int maxValue = Prompt("Введите число для максимального диапазона значений: ");

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
// PrintArray(SearcDiagonal(array));

int sum = SearchDiagonal(array);
Console.WriteLine(sum);

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

// void SearcSumDiagonal(int[,] arr)
// {
//     int sum = 0;
//     int temp = 0;
//     for( int i = 0; i < arr.GetLength(0); i ++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             temp = j + 1;
//             sum = temp + i;
//         }
       
//     }
//     Console.WriteLine(sum);
//     // return 

// }

// int SearchDiagonal(int[,]result)
// {
//     int sum = 0;
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             if(i == j)
//             {
//                 sum = sum + result[i,j];
//             }
            
//         }
//     }
//     return sum; 
// }

int SearchDiagonal(int[,]result)
{
    int sum = 0;
    for ( int i = 0; i < result.GetLength(1); i ++)
    {
        sum += result[i, i];
    }
    return sum;
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