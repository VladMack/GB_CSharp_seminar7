namespace MyClasses;
using System;
public class MyExample
{
    ///<Summary>
    ///Создание массива от min до max
    ///</Summary>

    public static int[,] GetArray(int rows, int columns, int min, int max)
    {
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                result[i, j] = new Random().Next(min, max + 1);
            }

        }
        return result;
    }

    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}");
            }
            Console.WriteLine();
        }

    }

}
