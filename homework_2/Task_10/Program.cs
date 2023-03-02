string x = Console.ReadLine();
int userNumber = int.Parse(x);
int secondDigitNumber = userNumber / 10 % 10;

if (userNumber>999||userNumber<100)
{
    Console.WriteLine("error");
}
else
{
    Console.WriteLine(secondDigitNumber);
}



