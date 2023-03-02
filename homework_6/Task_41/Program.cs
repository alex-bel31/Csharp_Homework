string GetAndPrintValue(string msg)
{
    Console.Write(msg);
    string input = Console.ReadLine();
    return input;
}

string array = GetAndPrintValue("Введите массив: ");
string[] array1 = array.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array2 = new int[array1.Length];

for (int i = 0; i < array2.Length; i++)
{
    array2[i] = int.Parse(array1[i]);
}

int count = 0;
for (int i = 0; i < array2.Length; i++)
{
    if (array2[i] > 0)
    {
        count++;
        
    }
}

Console.Write($" -> {count}");
