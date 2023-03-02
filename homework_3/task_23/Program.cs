int PrintAndGetValue(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine();
    int value = int.Parse(input);
    return value;
}

int number = PrintAndGetValue("Введите число");

    for (var i = 1; i <= number; i++)
    {
        double result = Math.Pow(i, 3);
        Console.Write($"{result} ");
    }


