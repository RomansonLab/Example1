// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int arraysize = Prompt("Введите число элементов для случайного массива: ");
int arrayMin = Prompt("Введите минимально возможный элемент массива: ");
int arrayMax = Prompt("Введите максимально возможный элемент массива: ");
int[] createArray = randomArray();
Console.WriteLine();
PrintArray(createArray);


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] randomArray()
{
    int[] array = new int[arraysize];
    Random randomName = new Random();

    for(int i = 0; i < arraysize; i++)
        array[i] = randomName.Next(arrayMin, arrayMax+1);

    return array;
}

void PrintArray(int[] array)
{  
    int count = array.Length;

    for (int i =0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
