int m = GetAndPrintValue("Введите количество строк: ");
int n = GetAndPrintValue("Введите количество столбцов: ");

int GetAndPrintValue(string msg)
{
    Console.Write(msg);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

int[,] FillArray(int m, int n, int min, int max)
{

    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);

        }
    }
    return matrix;
}
int[,] array = FillArray(m, n, 1, 100);

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

double[] b = new double[n];

for (int i = 0, k = 0; i < array.GetLength(0); i++)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    b[k] = sum / n;
    Console.WriteLine("Среднее арифметическое строки" + (i + 1) + " равно: " + b[k]);
    k++;
}
PrintArray(array);



