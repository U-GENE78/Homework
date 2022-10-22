// Напишите программу, которая на вход принимает число и возвращает индексы элемента в двумерном массиве 
// или же указание, что такого элемента нет.

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

void Print(int[,] array)
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

void SearchArray(int[,] array, int number)
{
    bool numberFound = false;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.Write($"\nNumber {number} was found\nROW: {i+1}\nCOLUMN: {j+1}");
                numberFound = true;
                break;
            }
        }
        if (numberFound) break;
    }
    if (!numberFound) Console.WriteLine($"\nNumber {number} was not found\n");
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

Print(array);

Console.Write($"\nEnter the number to find: ");
int numberToFind = int.Parse(Console.ReadLine()!);

SearchArray(array, numberToFind);

