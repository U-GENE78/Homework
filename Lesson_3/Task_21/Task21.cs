//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

float Distance (int xa, int ya, int za, int xb, int yb, int zb)
{
    float distance = (float) Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));

    return distance;
}

int Prompt(char point, char coord)
{
    Console.Write($"Point {point}, Coordinate {coord}: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

Console.Clear();

float distBetweenPoints;

Console.WriteLine("Enter coordinates of point A");

int xa = Prompt('A', 'X');
int ya = Prompt('A', 'Y');
int za = Prompt('A', 'Z');

Console.WriteLine("\nEnter coordinates of point B");

int xb = Prompt('B', 'X');
int yb = Prompt('B', 'Y');
int zb = Prompt('B', 'Z');

distBetweenPoints = Distance (xa, ya, za, xb, yb, zb);

Console.WriteLine($"\nDistance between points A and B is {distBetweenPoints:f2}");
