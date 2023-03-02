Console.WriteLine("Введите число 1");
string number1 = Console.ReadLine();
int a = int.Parse(number1);
Console.WriteLine("Введите число 2");
string number2 = Console.ReadLine();
int b = int.Parse(number2);
Console.WriteLine("Введите число 3");
string number3 = Console.ReadLine();
int c = int.Parse(number3);
int maximum = a;

if (maximum < b)
{
    maximum = b;
}
else
{
    maximum = a;
}
if (maximum < c)
{
    maximum = c;
}
else
{
    Console.Write(maximum);
}
Console.Write("Максимальное:  ");
Console.Write(maximum);