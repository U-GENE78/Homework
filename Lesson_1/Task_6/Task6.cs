//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);
string str = "ODD"; //нечетное

if (number % 2 == 0) str = "EVEN"; //четное

Console.WriteLine($"Number {number} is {str}");
