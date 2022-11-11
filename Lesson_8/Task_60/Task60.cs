// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.

int[,,] Create3DArray(int rows, int cols, int arr, int minValue, int maxValue)
{
    int rand;

    bool[] availableNumbers = new bool[maxValue - minValue + 1];
    for(int i = 0; i < maxValue - minValue + 1; i++ ) availableNumbers[i] = true;

    int[,,] myArray = new int[rows, cols, arr];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            for (int k = 0; k < arr; k++)
            {
                do
                {
                    rand = new Random().Next(minValue, maxValue + 1);
                }
                while (!availableNumbers[rand - minValue]);                

                myArray[i, j, k] = rand;

                availableNumbers[rand - minValue] = false;
            }
    return myArray;
}

void Print3DArray(int[,,] array)
{
    Console.WriteLine($"\nDimension\tNumber\n");
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"[{i},{j},{k}]\t\t {array[i, j, k]}");
            }
}





///MAIN

Console.Clear();

int rowsX;
int columnsY;
int dimensionZ;
int minValue = 10;
int maxValue = 99;
do{
Console.Clear();

Console.Write("Enter the number of ROWS in 3D array: ");
do
{
    rowsX = int.Parse(Console.ReadLine()!);
} while (rowsX < 1);

Console.Write("Enter the number of COLUMNS in 3D array: ");
do
{
    columnsY = int.Parse(Console.ReadLine()!);
} while (columnsY < 1);

Console.Write("Enter the number of ARRAYS in 3d array: ");
do
{
    dimensionZ = int.Parse(Console.ReadLine()!);
} while (dimensionZ < 1);
if(rowsX * columnsY * dimensionZ > maxValue - minValue + 1)
{
    Console.WriteLine($"\nTOO MANY ELEMENTS\nPress any key to continue...");
    Console.ReadLine();
}
}while(rowsX * columnsY * dimensionZ > maxValue - minValue + 1);


int[,,] array3D = Create3DArray(rowsX, columnsY, dimensionZ, minValue, maxValue);

Print3DArray(array3D);

Console.WriteLine();
