// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int RowValue(int[,] array, int row)
{
    int length = array.GetLength(1);

    int sum = 0;

    for (int i = 0; i < length; i++)
    {
        sum += array[row, i];
    }
    return sum;
}

int RowWithMinValue(int[,] array)
{
    int minRowSum = RowValue(array, 0);

    int rowMinValue = 0;

    int length = array.GetLength(0);

    for (int i = 0; i < length; i++)
    {
        if (RowValue(array, i) < minRowSum)
        {
            minRowSum = RowValue(array, i);
            rowMinValue = i;
        }
    }
    return rowMinValue;
}

void PrintArray(int[,] array)
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

void PrintArrayLine(int[,] array, int rowMinValue)
{
    Console.WriteLine();
    Console.Write("[");
    for (int j = 0; j < array.GetLength(1)-1; j++)
    {
        Console.Write($"{array[rowMinValue, j]}\t");
    }
    Console.Write($"{array[rowMinValue,array.GetLength(1) -1]}]");
    Console.WriteLine();

}

///MAIN

Console.Clear();

int rows;
int cols;
int minValue;
int maxValue;

Console.Write("Enter the number of ROWS: ");
do
{
    rows = int.Parse(Console.ReadLine()!);
} while (rows < 1);

Console.Write("Enter the number of COLUMNS: ");
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

Console.WriteLine($"\nOriginal Array");

PrintArray(array);

int rowMinValue = RowWithMinValue(array);

Console.WriteLine($"\nRow {rowMinValue + 1} has the minimum sum of elements");

PrintArrayLine(array, rowMinValue);

Console.WriteLine();