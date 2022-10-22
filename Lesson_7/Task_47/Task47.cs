// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateArray(int rows, int cols, double minValue, double maxValue)
{
    double[,] myArray = new double[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            double newRandNumber = new Random().NextDouble();
            myArray[i, j] = newRandNumber * (maxValue - minValue) + minValue;
        }
    return myArray;
}

void Print(double[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2}\t");
        }
        Console.WriteLine();
    }
}

///// MAIN ////

Console.Clear();

int rows;
int cols;
double minValue;
double maxValue;

Console.Write("Enter the numer of ROWS: ");
do
{
    rows = int.Parse(Console.ReadLine()!);
} while (rows < 1);

Console.Write("Enter the numer of COLUMNS: ");
do
{
    cols = int.Parse(Console.ReadLine()!);
} while (cols < 1);

do
{
    Console.Write("Enter the minimum value: ");
    minValue = double.Parse(Console.ReadLine()!);

    Console.Write("Enter the maximum value: ");
    maxValue = double.Parse(Console.ReadLine()!);

    if (minValue > maxValue) Console.WriteLine("Maximum value must be greater or equal to minimum value!");

} while (minValue > maxValue);

double[,] array = CreateArray(rows, cols, minValue, maxValue);

Print(array);
Console.WriteLine();
