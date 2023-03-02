int m = GetAndPrintValue("Введите количество строк: ");
int n = GetAndPrintValue("Введите количество столбцов: ");
int [,] array = new int[m, n];

int GetAndPrintValue(string msg)
{
    Console.Write(msg);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);

        }
    }
    return array;
}



int[,] SortArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  return array;
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
Console.WriteLine("Отсортированный массив: ");
SortArray(array);
PrintArray(array);


    

