int GetAndPrintValue(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine();
    int value = int.Parse(input);
    return value;
}

int SumOfDigits(int number)
{
    int result = 0;
    while (number > 0)
{
    result = result + number % 10;
    number = number /10 ;
}
return result;
}

int number = GetAndPrintValue("Введите число: ");
int result = SumOfDigits(number);
Console.WriteLine($"{number} -> {result}");
