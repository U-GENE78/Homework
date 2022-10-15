// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Реализация: складываются элементы с нечетными ИНДЕКСАМИ

int[] CreateArray(int num, int minValue, int maxValue)
{
    int[] newArray = new int[num];

    for(int i = 0; i < num; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }

    return newArray;
}

int SumOddIndex(int[] array)
{
    int sumOddIndex = 0;

    for(int i = 1; i < array.Length; i+=2)
    {
        sumOddIndex += array[i];
    }

    return sumOddIndex;
}

void Print(int[] arrayToPrint)
{
    Console.WriteLine($"\n{String.Join('\t', arrayToPrint)}");
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
    
    if(minValue > maxValue) Console.WriteLine("Maximum value must be greater or equal to minimum value!");

} while (minValue > maxValue );

int[] array = CreateArray(length, minValue, maxValue);

Print(array);

Console.WriteLine($"\nNumber of elements with odd indexes is {SumOddIndex(array)}\n");



