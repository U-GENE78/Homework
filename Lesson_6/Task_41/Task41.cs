// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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
    int length = numberString.Length;
    int[] arr = new int[length/2 + 1]; // создаем потенциально избыточный массив 
                                    //по максимально возможному количеству чисел в строке
    while (i < length/2 + 1)
    {
        string tempNumber = string.Empty;
        bool flag = false;

        while (index < length)
        {
            if (IsDigit(numberString[index]))
            {
                tempNumber += numberString[index];
                flag = true;
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
        
        i++;
    }

    return arr;
}

int[] RemoveEmptyElements(int[] arrayToTrim, int numberOfElements) // убираем лишние элементы из массива
{
    int[] arrayChanged = new int[numberOfElements];

    for(int i = 0; i < numberOfElements; i++)
    {
        arrayChanged[i] = arrayToTrim[i];
    }

    return arrayChanged;
}

int NumberOfPositive(int[] arrayToCheck, int numberOfElements)
{
    int countPositiveNumbers = 0;

    for(int i = 0; i < numberOfElements; i++)
    {
        countPositiveNumbers += arrayToCheck[i] > 0 ? 1 : 0;
    }

    return countPositiveNumbers;
}

string Print(int[] array)
{
   string str = String.Join(" ", array);
   return str;    
}

//////

Console.Clear();

Console.Write("Enter any numbers separated by any symbols: ");

string numberString = Console.ReadLine()!;

if (numberString == string.Empty)
{
    Console.WriteLine("EMPTY STRING");
}
else
{
    int[] array = GetArray(numberString, out int count);

    if(array.Length > count) array = RemoveEmptyElements(array, count);
    
    Console.WriteLine($"\nThe array\n{Print(array)}\ncontains {NumberOfPositive(array, count)} positive numbers\n");
}

