/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


int GetCoordinate(string point, string axis)
{
    Console.Write($"Введите координату точки {point} по оси {axis}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int xA = GetCoordinate("A", "x");
int yA = GetCoordinate("A", "y");
int zA = GetCoordinate("A", "z");

int xB = GetCoordinate("B", "x");
int yB = GetCoordinate("B", "y");
int zB = GetCoordinate("B", "z");

double GetDecision(double xA, double xB, double yA, double yB, double zA, double zB)
{
   return Math.Sqrt(Math.Pow((xB-xA), 2) + Math.Pow((yB-yA), 2) + Math.Pow((zB-zA), 2));
}

double LengthOfLine =  Math.Round (GetDecision(xA, xB, yA, yB, zA, zB), 2 );

Console.WriteLine($"{LengthOfLine}");
