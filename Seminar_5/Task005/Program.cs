// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = RandomArray();
int[] arrayProduct = ArrayProduct(array);

PrintArray(array);
PrintArray(arrayProduct);

int[] ArrayProduct(int[] array)
{
    int[] arrayProduct = new int[(array.Length / 2) + 1];

    for(int i = 0; i < (array.Length / 2) + 1; i++)
    {
        if(i == (array.Length / 2))
            arrayProduct[i] = array[i];
        else
            arrayProduct[i] = array[i] * array[(array.Length - 1) - i];
    }
        
    return arrayProduct;
}

int[] RandomArray()
{
    int[] array = new int[5];
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(-10, 11);

    return array;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}


// // / Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// // Парой считаем первый и последний элемент, второй и предпоследний
// // и т.д. Результат запишите в новом массиве. 
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

// int size = Prompt("Введите размерность массива: ");
// int minValue = Prompt("Введите минимальное число диапазона массива: ");
// int maxValue = Prompt("Введите максимальное число диапазона массива: ");
// int[] array = GetArray(size, minValue, maxValue);
// PrintArray(array);
// Console.Write(" -> ");
// PrintArray(SearchArray(array));

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

// int[] SearchArray(int[] arr)
// {
//     int index = 0;
//     int[] resArray = new int[(arr.Length + 1) / 2];
//     for(int i =0; i < arr.Length / 2; i++)
//     {  
//         resArray[i] = arr[i] * arr[(arr.Length - 1) - i];
//     }
//     if(arr.Length % 2 == 1)
//     {
//         resArray[(arr.Length - 1) / 2] = arr[(arr.Length - 1) / 2];
//     }
//     return resArray;
// }