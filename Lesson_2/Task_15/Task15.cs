//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 1 - понедельник...7 - воскресенье

Console.Clear();

int number;

string isWeekend = "Not a Weekend";

do
{
    Console.Write("Enter a weekday number (1..7): ");
    number = int.Parse(Console.ReadLine()!);
}
while (number < 1 || number > 7);

if (number == 6 || number == 7)
{
    isWeekend = "It is a Weekend";
}

Console.Write($"\n{isWeekend}");