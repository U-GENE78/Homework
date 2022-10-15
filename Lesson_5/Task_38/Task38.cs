// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int num, double minValue, double maxValue)
{
    double[] newArray = new double[num];
    double newRandNumber;

    for(int i = 0; i < num; i++)
    {
        newRandNumber = new Random().NextDouble();
        newArray[i] = newRandNumber * (maxValue - minValue) + minValue; 
    }

    return newArray;
}

double MinMaxDiff(double[] array)
{
    double min = array[0];
    double max = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] < min){
        min = array[i];
        }
        else if (array[i] > max){
        max = array[i];}        
    }
    
    return (max - min);
}

void Print(double[] arrayToPrint)
{
    Console.WriteLine($"\n{String.Join('\t', arrayToPrint)}");
}

////

Console.Clear();

int length;
double minValue;
double maxValue;

do
{
    Console.Write("Enter the array length: ");
    length = int.Parse(Console.ReadLine()!);
} while (length < 1);

do
{
    Console.Write("Enter the minimum value: ");
    minValue = Double.Parse(Console.ReadLine()!);

    Console.Write("Enter the maximum value: ");
    maxValue = Double.Parse(Console.ReadLine()!);
    
    if(minValue > maxValue) Console.WriteLine("Maximum value must be greater or equal to minimum value!");

} while (minValue > maxValue );

double[] array = CreateArray(length, minValue, maxValue);

Print(array);

Console.WriteLine($"\nDifference between max and min values is {MinMaxDiff(array)}\n");

