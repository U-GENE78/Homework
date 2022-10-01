//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
//из этих чисел.

Console.Clear();

Console.Write("Enter FIRST number: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Enter SECOND number: ");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.Write("Enter THIRD number: ");
int thirdNumber = int.Parse(Console.ReadLine()!);

int maxNumber = firstNumber;

if (secondNumber > maxNumber) maxNumber = secondNumber;

if (thirdNumber > maxNumber) maxNumber = thirdNumber;

Console.WriteLine($"\nMaximum number is {maxNumber}");