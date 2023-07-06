// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;
class HelloWorld {
  static void Main() {
      int m=10;
      int n=10;
      int [,]arr=GetArray(m,n,0,1000);
      PrintArray(arr);
      swap(arr,m,0,n-1);
      
      Console.WriteLine();
      PrintArray(arr);
      
    
  }
  static int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max); // [0,0] , [0,1] , [0,2]....//[1,0], [1,1] , [1,2]

        }
    }
    return result;
}
    static void swap(int[,]arr,int m, int swapfirst,int swapsecond)
    {
        for(int i=0;i<m;++i)
        {
            int tmp=arr[swapfirst,i];
            arr[swapfirst,i]=arr[swapsecond,i];
            arr[swapsecond,i]=tmp;
        }
    }
    static
    void PrintArray(int[,] arr)
{
      for(int i = 0; i < arr.GetLength(0); i++)  // длина строки
    {
        for(int j = 0; j < arr.GetLength(1); j++)  // длина столбца
        {
            Console.Write(arr[i,j] + " ");
         
        }
        Console.WriteLine();
    }
}
}