// Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, 
// состоящем из символов, сгруппированных в упорядоченные пары.

bool CheckSequence(string str, int pos, string charString)
{
    if (str[pos] == '{' || str[pos] == '[' || str[pos] == '(')
    {
        charString += str[pos];
        if (pos < str.Length - 1)
        {
            return CheckSequence(str, ++pos, charString);
        }
        else return false;
    }

    if ((str[pos] == '}' || str[pos] == ']' || str[pos] == ')'))
    {
        if ((!(charString == string.Empty)) &&
        (str[pos] == '}' && charString[charString.Length - 1] == '{') ||
        (str[pos] == ']' && charString[charString.Length - 1] == '[') ||
        (str[pos] == ')' && charString[charString.Length - 1] == '('))
        {
            charString = charString.Substring(0, charString.Length - 1);
            if (pos < str.Length - 1) return CheckSequence(str, ++pos, charString);
        }
        else return false;
    }

    if (pos == str.Length - 1)
    {
        if (charString == string.Empty) return true;
        else return false;
    }
    return CheckSequence(str, ++pos, charString);
}

/// MAIN

Console.Clear();

string str = "{sg[g(sghdh)ll]l}";

int pos = 0;

string charString = string.Empty;

if (CheckSequence(str, pos, charString)) Console.WriteLine($"Sequence {str} is VALID");
else Console.WriteLine($"Sequence {str} is INVALID");

Console.WriteLine();