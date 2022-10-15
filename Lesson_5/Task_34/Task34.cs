// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int num, int minValue, int maxValue)
{
    int[] newArray = new int[num];

    for(int i = 0; i < num; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue);
    }

    return newArray;
}

int CountEvenNumbers(int[] array)
{
    int countEven = 0;

    foreach(int number in array)
    {
        countEven += (number % 2 == 0) ? 1 : 0;
    }

    return countEven;
}

void Print(int[] arrayToPrint)
{
    Console.WriteLine($"\n{String.Join('\t', arrayToPrint)}");
}


Console.Clear();

int length;

do
{
    Console.Write("Enter the array length: ");
    length = int.Parse(Console.ReadLine()!);
} while (length < 1);

int[] array = CreateArray(length, 100, 1000);

Print(array);

Console.WriteLine($"\nNumber of even numbers is {CountEvenNumbers(array)}\n");