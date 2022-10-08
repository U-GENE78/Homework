//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

//Решение приведено для общего случая

int NumberOfDigits(int num) // считаем количество цифр
{
    int dig = 0;

    while (num >= 1)
    {
        num /= 10;
        dig++;
    }

    return dig;
}

bool IsPalindrome(int number)
{
    int firstDigit;
    int lastDigit;
    int powOfTen;

    int numOfDigits = NumberOfDigits(number);

    while (numOfDigits > 1)
    {
        powOfTen = (int)Math.Pow(10, numOfDigits - 1);

        firstDigit = number / powOfTen;
        lastDigit = number % 10;

        if (firstDigit != lastDigit) return false;

        number = (number - firstDigit * powOfTen) / 10;
        numOfDigits = numOfDigits - 2;
    }

    return true;

}

Console.Clear();

string msg;

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

if (IsPalindrome(number))
{
    msg = "a PALINDROME";
}
else
{
    msg = "NOT a palindrome";
}

Console.WriteLine($"\nNumber {number} is {msg}");