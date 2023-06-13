// // Напишите программу, которая выводит 
// случайное трехзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int number = new Random().Next(100,1000);

int firstValue = number/100;
int thirdValue = number%10;
int newvalue = firstValue * 10 + thirdValue;

Console.WriteLine(number + " " + firstValue + " " + thirdValue + " " + newvalue);

