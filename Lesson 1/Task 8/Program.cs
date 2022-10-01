//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
//все чётные числа от 1 до N.

Console.Clear();

int number;

do
{
    Console.Write("Enter a POSITIVE number: ");
    number = int.Parse(Console.ReadLine()!);
}
while (number <= 0);

Console.WriteLine();

for (int i = 2; i < number; i = i + 2)
{
    Console.Write(i + "\t");
}