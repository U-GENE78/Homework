// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string NumbersDescending(int number)
{
    return number == 1 ? "1" : $"{number}, " + NumbersDescending(number - 1);
}

/// MAIN

Console.Clear();

int maxValue;

Console.Write("Enter a number: ");
do
{
    maxValue = int.Parse(Console.ReadLine()!);
} while (maxValue < 1);

Console.WriteLine($"{NumbersDescending(maxValue)}");
