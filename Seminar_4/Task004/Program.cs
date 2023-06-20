// Задача 30: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// https://metanit.com/sharp/tutorial/2.4.php


const int ARRAYSIZE = 100;
int[] randomBinaryArray = RandomBinaryArray();
PrintArray(randomBinaryArray);

int[] RandomBinaryArray()
{
    int[] array = new int[ARRAYSIZE];
    Random randomName = new Random();

    for(int i = 0; i < ARRAYSIZE; i++)
        array[i] = randomName.Next(0, 2);

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
