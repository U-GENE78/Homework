//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
//степень B. Реализовать функцию возведения в степень самостоятельно!

int NumToPower(int num, int pow)
{

    int result = num;

    for(int i = 1; i < pow; i++)
    {
        result *= num;
    }

    return result;
}



Console.Clear();

int number;
int power;

Console.Write("Enter a number: ");
number = int.Parse(Console.ReadLine()!);

do
{
    Console.Write("Enter a power: ");
    power = int.Parse(Console.ReadLine()!);
}
while (power < 1);

Console.WriteLine($"Number {number} to the power of {power} is {NumToPower(number, power)}\n");