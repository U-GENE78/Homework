// Написать программу для перевода римских чисел в десятичные арабские.

// Разрешенные символы:	I	V	X	L	C	D	M (1 5	10	50	100	500	1000)
// Разрешенные комбинации: от большего к меньшему, кроме IV, IX, XL, XC, CD, CM

bool IsRomanNumber(string value)
{
    for (int i = 0; i < value.Length; i++)
    {
        if (value[i] != 'I' && value[i] != 'V' && value[i] != 'X' && value[i] != 'L' && value[i] != 'C' && value[i] != 'D'
        && value[i] != 'M') return false;
    }
    return true;
}

int GetDigit(char charValue)
{
    int number;

    switch (charValue)
    {
        case 'M':
            number = 1000;
            break;

        case 'D':
            number = 500;
            break;

        case 'C':
            number = 100;
            break;

        case 'L':
            number = 50;
            break;

        case 'X':
            number = 10;
            break;

        case 'V':
            number = 5;
            break;

        default:
            number = 1;
            break;
    }
    return number;
}

int? ConvertToRoman(string romanValue)
{
    int length = romanValue.Length;
    int index = 0;

    int digit;
    int nextDigit;

    int number = 0; // накопление суммы

    int repNumbers = 1;
    int allowedDigit = 1000;

    while (index < length)
    {
        digit = GetDigit(romanValue[index]);
        nextDigit = 0;

        if (index < length - 1)
        {
            nextDigit = GetDigit(romanValue[index + 1]);
        }

        if (digit > nextDigit && digit <= allowedDigit)
        {
            number += digit;
            allowedDigit = digit;
            repNumbers = 1;
        }

        else if (digit > allowedDigit) return null;

        else if (digit == nextDigit)
        {
            if (digit < 1000) repNumbers++;
            if (digit == 500 || digit == 50 || digit == 5 || repNumbers > 3) return null;
            number += digit;
        }

        else // проверка на предпозицию IV, IX, XL, XC, CD, CM
        {
            switch (digit + nextDigit)
            {
                case 6:
                    digit = 4;
                    allowedDigit = 0;
                    index++;
                    break;

                case 11:
                    digit = 9;
                    allowedDigit = 0;
                    index++;
                    break;

                case 60:
                    digit = 40;
                    allowedDigit = 5;
                    index++;
                    break;

                case 110:
                    digit = 90;
                    allowedDigit = 5;
                    index++;
                    break;

                case 600:
                    digit = 400;
                    allowedDigit = 50;
                    index++;
                    break;

                case 1100:
                    digit = 900;
                    allowedDigit = 50;
                    index++;
                    break;

                default:
                    return null;
            }
            number += digit;
        }
        index++;
    }
    return number;
}

//// MAIN ////

Console.Clear();
Console.Write("Enter a number in Roman format: ");
string value = Console.ReadLine()!;

string romanValue = value.ToUpper();

if (!IsRomanNumber(romanValue)) Console.WriteLine($"{romanValue} contains invalid characters");
else
{
    int? number = ConvertToRoman(romanValue);
    if (number == null) Console.WriteLine($"{romanValue} has incorrect format");
    else
    {
        Console.Write($"{romanValue} --> {number}");
    }
}