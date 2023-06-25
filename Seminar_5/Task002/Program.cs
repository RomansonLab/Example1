// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальное число в массиве: ");
int maxValue = Prompt("Введите максимальное число в массиве: ");
int[] array = GetArray(size,minValue,maxValue);
PrintArray(array);
Console.WriteLine();
int[] reverseSignArray = ReverseSign(array);
PrintArray(array);


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
        // Console.Write($"{result[i]} ");
    }
    return result;
}

void PrintArray(int[] arr )
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] ReverseSign(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

// // Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] array = RandomArray();
// int[] reverseSignArray = ReverseSign(array);
// PrintArray(array);
// PrintArray(reverseSignArray);

// int[] ReverseSign(int[] array)
// {
//     int[] reverse = new int[array.Length];
    
//     for(int i = 0; i < array.Length; i++)
//     {
//         reverse[i] = array[i] * -1;
//     }

//     return reverse;
// }

// int[] RandomArray()
// {
//     int[] array = new int[10];
//     Random random = new Random();

//     for(int i = 0; i < array.Length; i++)
//         array[i] = random.Next(-10, 11);

//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach(var element in array)
//         Console.Write($"{element} ");

//     Console.WriteLine();
// }