/*Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
С помощью команд он может попросить сконвертировать одну валюту в другую. 
Курс конвертации просто описать в программе. 
Программа заканчивает свою работу в тот момент, когда решит пользователь.
*/
Console.WriteLine("Конвертер валют");
int i = 0;
string? exit = "exit";
var curr = String.Empty;


for ( ; ; )
{
    i++;
    Console.Write("В какой валюте у вас сбережения: ");
    curr = Console.ReadLine();
    string rub = "rub";
    string usd = "usd";
    string eur = "eur";
    string gbp = "gbp";
    
    if (curr == exit) break;
    WroneCommand(curr);
    AllarmHelp (curr);

    Console.Write("Какой ваш баланс: ");
    double balance = Convert.ToDouble(Console.ReadLine());
    if (curr == exit) break;
    if (curr == "usd")
    {
        balance = balance * 71.02;
    }
    if (curr == "eur")
    {    
        balance = balance * 74.56;
    }
    if (curr == "gbp")
    {
        balance = balance * 88.35;
    }
    
    
    Console.Write("В какую валюту вы хотите конвертировать: ");
    curr = Console.ReadLine();
    if (curr == exit) break;
    WroneCommand(curr);
    AllarmHelp( curr );

    if (curr == usd)
    {
        balance = balance * 0.0141;
    }
    if (curr == eur)
    {    
        balance = balance * 0.0134;
    }
    if (curr == gbp)
    {
        balance = balance * 0.0113;
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"У вас будет " + balance + " " + curr);
    Console.ResetColor();

    

void WroneCommand (string? unCorrect)
{
    while (unCorrect != eur && unCorrect != usd && unCorrect != gbp && unCorrect != rub)
    {
        Console.Write("Неверная команда, введите курс валют: ");
        unCorrect = Console.ReadLine();
        Console.WriteLine("(Можете ввести команду help для помощи) ");  
        AllarmHelp(unCorrect);
        if (unCorrect == exit) break;
    } 
}

void AllarmHelp (string? commHelp)
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


