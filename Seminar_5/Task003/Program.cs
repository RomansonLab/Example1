// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальное число в массиве: ");
int maxValue = Prompt("Введите максимальное число в массиве: ");
int userNumber = Prompt("Введите искомое число: ");
int[] array = GetArray(size,minValue,maxValue);
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

if(FindUserNumber(userNumber, array))
    Console.WriteLine($"Число {userNumber} содержится");
else
    Console.WriteLine($"Число {userNumber} несодержится");


bool FindUserNumber(int userNumber, int[] array)
{
    bool isFind = false;

    foreach (var el in array)
    {
        if (el == userNumber)
            isFind = true;
    }

    return isFind;
}