// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortDescendingMatrix(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    int temp;
    
    for (int k = 0; k < rows; k++)
    {
        for (int i = 0; i < columns - 1; i++)
            for (int j = i + 1; j < columns; j++)
                if (array[k, j] > array[k, i])
                {
                    temp = array[k, j];
                    array[k, j] = array[k, i];
                    array[k, i] = temp;
                }
    }
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

///MAIN

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

Console.WriteLine($"\nOriginal Array");

PrintArray(array);

SortDescendingMatrix(array);

Console.WriteLine($"\nSorted Array");

PrintArray(array);

Console.WriteLine();