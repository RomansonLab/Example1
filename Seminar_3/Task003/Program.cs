// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// //A (3,6); B (2,1) -> 5,09 
// //A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int x1 = Prompt("Введите x1 ");
int y1 = Prompt("Введите y1 ");
int x2 = Prompt("Введите x2 ");
int y2 = Prompt("Введите y2 ");

FindDistance(x1,y1,x2,y2);

void FindDistance(int X1, int Y1, int X2, int Y2)
{
    double result = Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1));
    Console.WriteLine(result.ToString("0.##"));
}