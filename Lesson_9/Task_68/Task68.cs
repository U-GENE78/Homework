// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if(m == 0) return n+1;

    else if(n == 0) return Ackermann(m - 1, 1);

    else return Ackermann(m-1, Ackermann(m, n-1));
}


///MAIN

Console.Clear();

int mValue;
int nValue;

    Console.Clear();
do{
    Console.Write("Enter m in A(m,n): ");
    mValue = int.Parse(Console.ReadLine()!);

    Console.Write("Enter n in A(m,n): ");
    nValue = int.Parse(Console.ReadLine()!);
}
while(mValue < 0 || nValue < 0);

Console.WriteLine($"The function A({mValue},{nValue}) returns {Ackermann(mValue,nValue)}");