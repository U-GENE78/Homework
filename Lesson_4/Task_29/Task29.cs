// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Особенности реализации: программа считает разделителями любые символы, отличные от цифр и знака минус.

bool IsDigit(char checkChar)
{
    if (checkChar >= '0' && checkChar <= '9') return true;
    return false;
}

bool IsMinus(char checkChar)
{
    if (checkChar == '-') return true;
    return false;
}

int[] GetArray(string numberString, out int count)
{
    int i = 0;
    int index = 0;
    count = 0;
    int[] arr = new int[8];
    int length = numberString.Length;

    while (i < 8)
    {
        string tempNumber = string.Empty;
        bool flag = false;

        while (index < length)
        {
            if (IsDigit(numberString[index]))
            {
                tempNumber += numberString[index];
                if (flag == false) flag = true;
            }
            else if (IsMinus(numberString[index]))
            {
                if (flag == true)
                {
                    index--;
                    break;
                }
                else
                {
                    tempNumber += '-';
                }
            }
            else if (flag == true)
            {
                break;
            }
            index++;
        }

        if (tempNumber != string.Empty)
        {
            arr[i] = int.Parse(tempNumber);
            count++;
        }

        // Console.Write($"{i} {index} {arr[i]}");
        i++;
    }

    return arr;
}

void Print(int[] array, int count)
{
    Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < count - 1; i++)
    {
        Console.Write($"{array[i]},\t");
    }
    Console.Write($"{array[count - 1]}]");
}

Console.Clear();

Console.Write("Enter up to 8 numbers separated by any symbols: ");

string numberString = Console.ReadLine()!;

if (numberString == string.Empty)
{
    Console.WriteLine("EMPTY STRING");
}
else
{
    int[] array = GetArray(numberString, out int count);
    Print(array, count);
}

