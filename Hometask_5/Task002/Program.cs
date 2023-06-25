// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int arraysize = Prompt("Введите число элементов для случайного массива: ");
int arrayMin = Prompt("Введите минимально возможный элемент массива: ");
int arrayMax = Prompt("Введите максимально возможный элемент массива: ");
int[] createArray = randomArray();
Console.WriteLine();
PrintArray(createArray);
int sumOfOddElements = OddCounter(createArray);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sumOfOddElements}");


int OddCounter(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) // Проверка на нечетную позицию
        {
            sum += array[i];
        }
    }

    return sum;
}



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


