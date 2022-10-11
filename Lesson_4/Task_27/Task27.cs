// Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits (int num)
{
    int sum = 0;

    num = Math.Abs(num);

    while (num >= 1)
    {
        sum += num % 10;
        num = num / 10;
    }

    return sum;
}

Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"\nSum of digits in number {number} is {SumOfDigits(number)}\n");