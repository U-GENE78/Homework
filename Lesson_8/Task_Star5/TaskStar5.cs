// Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x
// и возвращает целую часть квадратного корня от введенного числа.

int SqRoot(int number)
{
    int sqRoot = 0;
    int oddNumbers = 1;

    while(number >= oddNumbers)
    {
        number -= oddNumbers;
        sqRoot++;
        oddNumbers += 2;
    }

    return sqRoot;
}

///MAIN

Console.Clear();

int number;

Console.Write("Enter a number: ");
do
{
    number = int.Parse(Console.ReadLine()!);
} while (number < 0);

Console.WriteLine($"Square root of {number} is approximately {SqRoot(number)}");
