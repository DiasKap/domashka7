using System;
using static System.Console;

Write("Кол-во строк: ");
int rows = int.Parse(ReadLine()!);

Write("Кол-во колон: ");
int columns = int.Parse(ReadLine()!);

double[,] array = GetArray(rows, columns);

PrintArray(array);

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().Next(-30, 50) / 1.5, 2);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + "\t");
        }
        WriteLine();
    }
}