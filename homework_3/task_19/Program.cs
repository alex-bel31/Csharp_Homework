string PrintAndGetValue(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine();
    return input;
}
string digit = PrintAndGetValue("Введите пятизначное число");

void IsPalindrom(string digit)
{
    if(digit[0] == digit[4] && digit[1] == digit[3]) Console.WriteLine($"{digit}->да");
    else Console.WriteLine($"{digit}->нет");
    
   
}
IsPalindrom(digit);


