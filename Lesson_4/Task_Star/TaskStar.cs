// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

void Draw(char symbol, int height)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < height - i - 1; j++)
            Console.Write(' ');

        for (int k = 0; k < 2 * i + 1; k++)
            Console.Write(symbol);

        Console.WriteLine();
    }
}



Console.Clear();

int height;

do
{
    Console.Write("Enter the height: ");
    height = int.Parse(Console.ReadLine()!);
}
while (height <= 0);

Console.WriteLine();

Draw('*', height);
