Console.Clear();

Console.WriteLine("Введи высоту и ширину квадратного массива:");
int m = int.Parse(Console.ReadLine());
int[,] numbers = GetArray(m, 0, 10);
Console.WriteLine();
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine(FindSum(numbers));


int[,] GetArray(int rowsColumns, int min, int max)
{
    int[,] result = new int[rowsColumns, rowsColumns];

    for (int i = 0; i < rowsColumns; i++)
    {
        for (int j = 0; j < rowsColumns; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int FindSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, i];
    }
    return sum;
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