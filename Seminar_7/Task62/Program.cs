// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод 
// в виде равнобедренного треугольника

using System;
class HelloWorld {
  static void Main() {
      int m=20;
    
      int []arrc=new int[m];
      int []arrn=new int[m];
      for(int i=0;i<m;++i)
      {
          arrc[i]=1;
      }
      PrintArray(arrc,m);
      int rs=m-1;
      while(rs!=0)
      {
          arrn[0]=1;
          for(int i=1;i<rs;++i)
          {
              arrn[i]=arrc[i]+arrn[i-1];
          }
          for(int i=0;i<rs;++i)
          {
              arrc[i]=arrn[i];
          }
          PrintArray(arrc,rs);
          --rs;
      }
      
    
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
   
    static
    void PrintArray(int[] arr,int m )
{
      for(int i = 0; i < m; i++)  // длина строки
    {
         
            Console.Write(arr[i] + " ");
         
        }
        Console.WriteLine();
    
}
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

static int [,] remove(int[,]arr ,int m,int n,int i,int j)
{
    int [,]result =new int[m-1,n-1];
    int icorection=0;
    
    for(int k=0;k<m;++k)
    {
        if(i==k){icorection=1;continue;}
        int jcorrection=0;
        for(int l=0;l<n;++l)
        {
            if(j==l){jcorrection=1;continue;}
            result[k-icorection,l-jcorrection]=arr[k,l];
        }
        
    }
    return result;
}
static (int,int) minindex(int[,]arr,int m,int n)
{
    int mi=0;
    int mj=0;
    int min=arr[0,0];
    for(int i = 0; i < m; i++)  // длина строки
    {
        for(int j = 0; j < n; j++)  // длина столбца
        {
            if(min>arr[i,j])
            {
                min=arr[i,j];
                mi=i;
                mj=j;
            }
         
        }
       
    }
    return (mi,mj);
    
}
    
}