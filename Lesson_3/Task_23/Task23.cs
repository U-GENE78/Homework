//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void PrintCubes(int number)
{

    Console.WriteLine($"\nNUMBERS\t |\tCUBES");
    Console.WriteLine();

    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i}\t |\t {i * i * i}");
    }
}

Console.Clear();

int number;

do
{
    Console.Write("Enter a POSITIVE number: ");
    number = int.Parse(Console.ReadLine()!);
}
while (number < 1);

PrintCubes(number);
