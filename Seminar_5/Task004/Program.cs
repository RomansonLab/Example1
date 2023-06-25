﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = RandomArray();
int counter = Counter(array);
PrintArray(array);

Console.WriteLine(counter);

int Counter(int[] array)
{
    int counter = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 & array[i] < 100)
            counter++;
    }

    return counter;
}

int[] RandomArray()
{
    int[] array = new int[12];
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(-10, 150);

    return array;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}



// // Задача 35: Задайте одномерный массив из 123 случайных чисел.
// // Найдите количество элементов массива, значения которых лежат в
// // отрезке [10,99].
// // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5

// int size = Prompt("Введите размерность массива: ");
// int minValue = Prompt("Введите минимальное число диапазона массива: ");
// int maxValue = Prompt("Введите максимальное число диапазона массива: ");
// int[] array = GetArray(size, minValue, maxValue);
// PrintArray(array);
// Console.Write(" -> ");
// SearchArray(array);

// int Prompt(string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine()!);
//     return number;
// }
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for(int i =0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1); 
//     }
//     return result;
// }
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for(int i =0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.Write($"{arr[arr.Length-1]}"); //обращаемся к последнему элементу
//     Console.Write("]");
// }

// void SearchArray(int[] arr)
// {
//     int index = 0;
//     for(int i =0; i < arr.Length; i++)
//     {
//         if(arr[i] >= 10 && arr[i] <= 99)
//         {
//             index ++;
//         }
//     }
//     Console.Write(index);
// }