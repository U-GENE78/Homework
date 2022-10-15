//Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.

int[] CreateArray(int num, int minValue, int maxValue)
{
    int[] newArray = new int[num];

    for (int i = 0; i < num; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }

    return newArray;
}

void SortArray(int[] array)
{
    for (int j = 1; j < array.Length - 1; j++)
    {
        for (int i = 0; i < array.Length - j; i++)
        {
            if (array[i] < array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
}

void Print(int[] arrayToPrint)
{
    Console.WriteLine($"\n{String.Join(' ', arrayToPrint)}");
}

Console.Clear();

int length;
int minValue;
int maxValue;

do
{
    Console.Write("Enter the array length: ");
    length = int.Parse(Console.ReadLine()!);
} while (length < 1);

do
{
    Console.Write("Enter the minimum value: ");
    minValue = int.Parse(Console.ReadLine()!);

    Console.Write("Enter the maximum value: ");
    maxValue = int.Parse(Console.ReadLine()!);

    if (minValue > maxValue) Console.WriteLine("Maximum value must be greater or equal to minimum value!");

} while (minValue > maxValue);

int[] array = CreateArray(length, minValue, maxValue);

Console.Write($"\nOriginal array: \n");

Print(array);

if(length > 1) SortArray(array);

Console.Write($"\nSorted array: \n");

Print(array);

