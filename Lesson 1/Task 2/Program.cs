//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
//а какое меньшее.

Console.Clear();

Console.Write("Enter FIRST number: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Enter SECOND number: ");
int secondNumber = int.Parse(Console.ReadLine()!);

if (firstNumber > secondNumber)
    Console.WriteLine($"FIRST number ({firstNumber}) is greater than SECOND number ({secondNumber})");
else if (firstNumber < secondNumber)
    Console.WriteLine($"SECOND number ({secondNumber}) is greater than FIRST number ({firstNumber})");
else Console.WriteLine("Numbers are EQUAL");
