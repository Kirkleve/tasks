/*Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
С помощью команд он может попросить сконвертировать одну валюту в другую. 
Курс конвертации просто описать в программе. 
Программа заканчивает свою работу в тот момент, когда решит пользователь.
*/
Console.WriteLine("Конвертер валют");
int i = 0;
string exit = "exit";
string in_Currency = String.Empty;
string on_Currency = String.Empty;

while ( exit != in_Currency && exit != on_Currency )
{
    i++;
    Console.WriteLine("В какой валюте у вас сбережения");
    in_Currency = Console.ReadLine();
    string rub = "rub";
    string usd = "usd";
    string eur = "eur";
    string gbp = "gbp";
    
    WroneCommand(in_Currency);
    AllarmHelp (in_Currency);
    
    Console.WriteLine("Какой ваш баланс?");
    double balance = Convert.ToDouble(Console.ReadLine());
   
    if (in_Currency == "usd")
    {
        balance = balance * 71.02;
    }
    if (in_Currency == "eur")
    {    
        balance = balance * 74.56;
    }
    if (in_Currency == "gbp")
    {
        balance = balance * 88.35;
    }
    
    
    Console.WriteLine("В какую валюту вы хотите конвертировать?");
    on_Currency = Console.ReadLine();

    WroneCommand(on_Currency);
    AllarmHelp( on_Currency );

    if (on_Currency == usd)
    {
        balance = balance * 0.0141;
    }
    if (on_Currency == eur)
    {    
        balance = balance * 0.0134;
    }
    if (on_Currency == gbp)
    {
        balance = balance * 0.0113;
    }
    Console.WriteLine($"У вас будет " + balance + " " + on_Currency);
    Console.WriteLine();


void WroneCommand (string unCorrect)
{
    while (unCorrect != eur && unCorrect != usd && unCorrect != gbp && unCorrect != rub)
    {
        Console.Write("Неверная команда, введите курс валют: ");
        unCorrect = Console.ReadLine();
        Console.WriteLine("(Можете ввести команду help для помощи) ");  
        AllarmHelp(unCorrect);
    }
    return; 
}

void AllarmHelp (string commHelp)
{
    if ( commHelp == "help")
    {
        Console.WriteLine("Список команд:");
        Console.WriteLine("rub - курс рубля");
        Console.WriteLine("usd - курс доллара");
        Console.WriteLine("eur - курс евро");
        Console.WriteLine("gbp - фунт стерлингов");
        Console.WriteLine("help - список команд");
        Console.WriteLine("exit - выход");
    }

}
}  



/*
void InRub (string rub)
{
    
    double cUsdToRub = balance * 71.02;
    double cEurToRub = balance * 74.56;
    double cGbpToRub = balance * 88.35;
}
void InUsd (string usd)
{
    double cRubToUsd = balance * 0.0141;
    double cEurToUsd = balance * 1.05;
    double cGbpToUsd = balance * 0.80;
}
void InEur(string eur)
{
    double cUsdToEur = balance * 0.95;
    double cRubToEur = balance * 0.0134;
    double cEurToGbp = balance * 0.84;
}
void InGbp(string gbp)
{
    double cRubToGbp = balance * 88.35;
    double cGbpToUsd = balance * 1.24;
    double cGbpToEur = balance * 1.18;
}

*/
