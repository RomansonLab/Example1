// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void findDegree(int A, int B)
{
    double degree = Math.Pow(A, B);
    Console.WriteLine($"{A} в степени {B} будет равно {degree}");
}


int a = Prompt("Введите число А: ");
int b = Prompt("Введите число B: ");
findDegree(a, b);