//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

string msg;

Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 99)
{
    int numberCheck = number;
    
    while (numberCheck >= 1000)
    {
        numberCheck /= 10;
    }

    msg = $"The third digit of {number} is {numberCheck % 10}";
}
else
{
    msg = $"The number is too small";
}

Console.Write($"\n{msg}");