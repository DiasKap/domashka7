using System;
using static System.Console;
WriteLine("Число для поиска: ");
int findN = int.Parse(ReadLine()!);

int a = new Random().Next(3, 7); 
int b = new Random().Next(4, 8); 
int[,] array = GetArray(a, b);
array[2, 2] = 17;
PrintArray(array);
FindNum(array,findN);

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(-20, 20);
        }
    }
    return result;
}

void PrintArray(int[,] array)
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

void FindNum(int[,] array, int findN)
{
    a = 0;
    b = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == findN)
            {
                result = 1;
                a = i;
                b = j;
            }
        }
    }
    if (result == 1) WriteLine($"Число находится в: {a + 1} строке, {b + 1} колонке.");
    else WriteLine("Нету такого числа в массиве");
}