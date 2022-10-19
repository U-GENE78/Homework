// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int Prompt(string equation, string coefficient)
{
    Console.Write($"Enter coefficient {coefficient} in {equation}:  ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

float GetX(int k1, int k2, int b1, int b2)
{
    return ((float)(b2 - b1)) / ((float)(k1 - k2));
}

float GetY(int k1, int b1, float x)
{
    return (k1 * x + b1);
}



Console.Clear();

int k1 = Prompt("y = k1 * x + b1", "k1");
int b1 = Prompt("y = k1 * x + b1", "b1");
int k2 = Prompt("y = k2 * x + b2", "k2");
int b2 = Prompt("y = k2 * x + b2", "b2");

string eq1 = ($"y = {k1} * x + {b1}");
string eq2 = ($"y = {k2} * x + {b2}");

if (k1 == k2 && b1 == b2) Console.WriteLine("\n!!!Lines lie upon each other\n");
else if (k1 == k2) Console.WriteLine("\n!!!Lines do not cross\n");
else
{
    float pointX = GetX(k1, k2, b1, b2);
    float pointY = GetY(k1, b1, pointX);

    Console.WriteLine($"Lines {eq1} and {eq2} cross at the point:\nX: {pointX}\nY: {pointY}\n");
}
