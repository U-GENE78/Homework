// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Решение для целых чисел

int SumOfNumbers(int min, int max)
{
    return min == max ? min : min + SumOfNumbers(min + 1, max);
}

///MAIN

Console.Clear();

int minValue;
int maxValue;

do
{
    Console.Clear();

    Console.Write("Enter the minimum value: ");
    minValue = int.Parse(Console.ReadLine()!);

    Console.Write("Enter the maximum value: ");
    maxValue = int.Parse(Console.ReadLine()!);

    if (minValue > maxValue)
    {
        Console.WriteLine("Maximum value must be greater or equal to minimum value!");
        Console.ReadLine();
    }

} while (minValue > maxValue);

Console.WriteLine($"Sum of natural numbers from {minValue} to {maxValue} is {SumOfNumbers(minValue, maxValue)}");
