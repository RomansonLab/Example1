// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double arraysize = (int)Prompt("Введите число элементов для случайного вещественного массива: ");
double arrayMin = Prompt("Введите минимально возможный элемент массива: ");
double arrayMax = Prompt("Введите максимально возможный элемент массива: ");
double[] createArray = randomArray();
Console.WriteLine();
PrintArray(createArray);
FindMinMax(createArray, out double minValue, out double maxValue);


double Prompt(string message)
{
    Console.Write(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double[] randomArray()
{
    double[] array = new double[(int)arraysize];
    Random randomName = new Random();

    double range = (int)arrayMax - (int)arrayMin;

    for(int i = 0; i < arraysize; i++)
        array[i] = randomName.NextDouble()*range + arrayMin;
        // Random.NextDouble(), генерирует число между 0 и 1 (не включая 1), и затем с помощью 
        // range + arrayMin мы его масштабируем его до нужного диапазона

    return array;
}

void PrintArray(double[] array)
{  
    int count = array.Length;

    for (int i =0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FindMinMax(double[] array, out double minValue, out double maxValue)
{
    minValue = array[0];
    maxValue = array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue)
            minValue = array[i];

        if (array[i] > maxValue)
            maxValue = array[i];
    }

    double minmaxDifference = maxValue - minValue;

    Console.WriteLine($"Мин значение массива {minValue}");
    Console.WriteLine($"Макс значение массива {maxValue}");
    Console.WriteLine($"Разница между Макс и Мин значениями массива {minmaxDifference}");
}

