//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Clear();

int number;

do
{
    Console.Write("Enter a THREE digit number: ");
    number = int.Parse(Console.ReadLine()!);
}
while (number < 100 || number > 999);

Console.Write($"\nThe second digit of {number} is {(number / 10) % 10}");

