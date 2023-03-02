int[,] array = new int[4, 4];

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);

        }
    }
    return array;
}

int minSumRow = 0;
int sumRow = SumRowArray(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRow = SumRowArray(array, i);
    if (sumRow > tempSumRow)
    {
        sumRow = tempSumRow;
        minSumRow = i;
    }
}

int SumRowArray(int[,] array, int i)
{
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine($"{minSumRow + 1} - строкa с наименьшей суммой ({sumRow}) элементов ");



