using System;
using static System.Console;

Write("Кол-во строк: ");
int a = int.Parse(ReadLine()!);

Write("Кол-во колон: ");
int b = int.Parse(ReadLine()!);

int[,] numbers = new int[a, b];
RandomNumbers(numbers);

for (int c = 0; c < numbers.GetLength(1); c++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, c]);
    }
    avarage = avarage / a;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);

void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            array[i, c] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int c = 0; c < array.GetLength(1); c++)
        {
            Console.Write(array[i, c] + " ");
        }
        Console.Write(" ]");
        Console.WriteLine(" ");
    }
}