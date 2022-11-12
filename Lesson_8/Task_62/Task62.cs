// Напишите программу, которая заполнит спирально массив 4 на 4.

// Общее решение для любой прямоугольной матрицы

int[,] CreateMatrix(int rowsCount, int columnsCount)
{
    int[,] myArray = new int[rowsCount,columnsCount];
           
    int rows = 0; 
    int columns = 0;

    int number = 1;
 
    myArray[rows,columns] = number;

    do{
    while(columns < columnsCount - 1 && myArray[rows,columns + 1] == 0)
    {   
        myArray[rows,++columns] = ++number;
    }

    while(rows < rowsCount - 1 && myArray[rows + 1,columns] == 0)
    {
        myArray[++rows,columns] = ++number;
    }

    while(columns > 0 && myArray[rows,columns - 1] == 0)
    {
        myArray[rows,--columns] = ++number;
    }

    while(rows > 0 && myArray[rows - 1,columns] == 0)
    {
        myArray[--rows,columns] = ++number;
    }    
    }while(number < rowsCount * columnsCount);

    return myArray;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:00}\t");
        }
        Console.WriteLine();
    }
}

/// MAIN

Console.Clear();

int rows;
int columns;

Console.Write("Enter the number of ROWS: ");
do
{
    rows = int.Parse(Console.ReadLine()!);
} while (rows < 1);

Console.Write("Enter the number of COLUMNS: ");
do
{
    columns = int.Parse(Console.ReadLine()!);
} while (columns < 1);

int[,] arraySpiral = CreateMatrix(rows,columns);

PrintArray(arraySpiral);

Console.WriteLine();