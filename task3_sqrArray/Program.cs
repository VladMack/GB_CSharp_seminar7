Console.Clear();

Console.WriteLine("Введи высоту массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введи ширину массива:");
int n = int.Parse(Console.ReadLine());

int[,] numbers = GetArray(m, n, 0, 10);
PrintArray(numbers);
Console.WriteLine();
SqrArray(numbers);
PrintArray(numbers);


int[,] GetArray(int rows, int columns, int min, int max)
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

void SqrArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
        }

    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }

}