// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] myArray = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            myArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return myArray;
}

double[] GetMeanValues(int[,] array)
{
    double[] meanColumns = new double[array.GetLength(1)];
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                temp += array[i, j];
            }
            meanColumns[j] = (double)temp / array.GetLength(0);
        }
    }
    return meanColumns;
}


void Print2D(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Print1D(double[] array)
{
    Console.WriteLine("== MEAN VALUES ==");
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]:F1}\t");
}

///// MAIN ////

Console.Clear();

int rows;
int cols;
int minValue;
int maxValue;

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
    minValue = int.Parse(Console.ReadLine()!);

    Console.Write("Enter the maximum value: ");
    maxValue = int.Parse(Console.ReadLine()!);

    if (minValue > maxValue) Console.WriteLine("Maximum value must be greater or equal to minimum value!");

} while (minValue > maxValue);

int[,] array = CreateArray(rows, cols, minValue, maxValue);

Print2D(array);

double[] meanColumns = GetMeanValues(array);

Print1D(meanColumns);

