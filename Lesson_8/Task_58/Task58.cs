// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Матрицы создаются набором случайных чисел. 

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

int[,] MultiplyMatrices(int[,] arrayA, int[,] arrayB)
{
    int rows = arrayA.GetLength(0);
    int cols = arrayB.GetLength(1);
    int[,] arrayC = new int[rows,cols];

    int commonDimension = arrayA.GetLength(1);

    for(int i = 0; i < rows; i++)
    for(int j = 0; j < cols; j++)
    {
        int sumProduct = 0;
        for(int k = 0; k < commonDimension; k++)
        {   
            sumProduct += arrayA[i,k] * arrayB[k,j];
        }
        arrayC[i,j] = sumProduct;
    }
    return arrayC;
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

int rowsMatrixA, colsMatrixA;
int rowsMatrixB, colsMatrixB;
int minValue;
int maxValue;

Console.Write("Enter the number of ROWS in MATRIX A: ");
do
{
    rowsMatrixA = int.Parse(Console.ReadLine()!);
} while (rowsMatrixA < 1);

Console.Write("Enter the number of COLUMNS in MATRIX A: ");
do
{
    colsMatrixA = int.Parse(Console.ReadLine()!);
} while (colsMatrixA < 1);


rowsMatrixB = colsMatrixA; // Автоматическая подстановка, чтобы умножение имело смысл
Console.Write($"Enter the number of ROWS in MATRIX B: {rowsMatrixB}\n"); 

Console.Write("Enter the number of COLUMNS in MATRIX B: ");
do
{
    colsMatrixB = int.Parse(Console.ReadLine()!);
} while (colsMatrixB < 1);

do
{
    Console.Write("Enter the minimum value: ");
    minValue = int.Parse(Console.ReadLine()!);

    Console.Write("Enter the maximum value: ");
    maxValue = int.Parse(Console.ReadLine()!);

    if (minValue > maxValue) Console.WriteLine("Maximum value must be greater or equal to minimum value!");

} while (minValue > maxValue);

int[,] arrayMatrixA = CreateArray(rowsMatrixA, colsMatrixA, minValue, maxValue);

int[,] arrayMatrixB = CreateArray(rowsMatrixB, colsMatrixB, minValue, maxValue);

Console.WriteLine($"\nMATRIX A: ");

PrintArray(arrayMatrixA);

Console.WriteLine($"\nMATRIX B: ");

PrintArray(arrayMatrixB);

int[,] arrayMatrixC = MultiplyMatrices(arrayMatrixA, arrayMatrixB);

Console.WriteLine($"\nMATRX A x MATRX B: ");

PrintArray(arrayMatrixC);

Console.WriteLine();
