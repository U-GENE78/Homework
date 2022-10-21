// Напишите программу, которая реализует обход введенного двумерного массива,
// начиная с крайнего нижнего левого элемента против часовой стрелки.

int[,] CreateArray(int rows, int cols) // создаем массив
{
    int[,] myArray = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            myArray[i, j] = i * cols + j + 1;
        }
    }

    return myArray;
}

int[] TransformArray(int[,] arrayToOneD) // считываем 2-мерный массив против часовой стрелки и заносим данные в 1-мерный
{
    int countRows = arrayToOneD.GetLength(0);
    int countCols = arrayToOneD.GetLength(1);

    int[] changedArray = new int[countRows * countCols];

    int rowDirection = 0; // направление считывания по столбцам (изменение индекса строк)
    int colDirection = 0; // направление считывания по строкам (изменение индекса столбцов)

    int currentRow = countRows - 1; // начальная строка
    int currentCol = -1; // начальный столбец, с учетом компенсации по направлению считывания массива
    int count = 0;

    int maxIterate = (countRows <= countCols) ? countRows * 2 - 1 : countCols * 2;

    for (int k = 0; k < maxIterate; k++) // количество проходов
    {

        switch (k % 4) // определяем направление движения
        {
            case 0:
                colDirection = 1;
                rowDirection = 0;
                break;

            case 1:
                colDirection = 0;
                rowDirection = -1;
                break;

            case 2:
                colDirection = -1;
                rowDirection = 0;
                break;

            case 3:
                colDirection = 0;
                rowDirection = 1;
                break;
        }

        int offsetStart = (k + 3) / 4;
        int offsetFinish = (k + 1) / 4;

        currentCol += colDirection;
        currentRow += rowDirection;

        for (int col = currentCol, row = currentRow; col < countCols - offsetFinish * colDirection &&
                 row < countRows - offsetFinish * rowDirection && col >= offsetFinish * Math.Abs(colDirection) &&
                 row >= offsetFinish * Math.Abs(rowDirection);
                col = col + colDirection, row = row + rowDirection)
        {
            changedArray[count] = arrayToOneD[row, col];
            currentCol = col;
            currentRow = row;
            count++;
        }
    }
    return changedArray;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.WriteLine();

    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"\t{arrayToPrint[i, j]:00}|");
        }
        Console.WriteLine();
    }
}

void Print1DArray(int[] arrayToPrint)
{
    Console.WriteLine();

    for (int i = 0; i < arrayToPrint.GetLength(0) - 1; i++)
    {
        Console.Write($"\t{arrayToPrint[i]:00} ->");
    }
    Console.Write($"\t{arrayToPrint[arrayToPrint.GetLength(0) - 1]:00 END}");
}

///// MAIN ////

Console.Clear();

int rows;
int cols;

Console.Write("Enter the numer of ROWS: ");
do
{
    rows = int.Parse(Console.ReadLine()!);
}
while (rows < 1);

Console.Write("Enter the numer of COLUMNS: ");
do
{
    cols = int.Parse(Console.ReadLine()!);
}
while (cols < 1);

int[,] array = CreateArray(rows, cols);

Print2DArray(array);

int[] transformedArray = TransformArray(array);

Print1DArray(transformedArray);

