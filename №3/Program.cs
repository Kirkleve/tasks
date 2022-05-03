/*Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, 
когда пишем exit еще 4 команды (их можно придумать самому). Например:

- SetName – Установить имя
- Help – вывести список команд
- SetPassword – Установить пароль
- WriteName – вывести имя после ввода пароля
*/
//Немного изменил задачу, не стал добавлять вторую задачу сюда
//пользователь сам решает когда выйти при помощи команды

string exit = "exit";
string help = "help";
string create = "create login";
string password = "create password";
string initialization = "init";
string log = String.Empty;
string pass = String.Empty;
Console.WriteLine("Введите команду (команда " + help + " выведет на экран список возможных команд):");
int i = 0;
for (; ; )
{
    i++;
    string command = Console.ReadLine();
    if (command == help)
    {
        Console.WriteLine("Список команд: ");
        Console.WriteLine($"" + create + " - создать имя пользователя.");
        Console.WriteLine($"" + password + " - создать парроль.");
        Console.WriteLine($"" + initialization + " - инициализация вашего логина");
        Console.WriteLine($"" + exit + " - выход");
    }
    if (command == create)
    {
        Console.Write("создайте ваш логин: ");
        log = Console.ReadLine();
        Console.Write("создайте ваш пароль: ");
        pass = Console.ReadLine();
        Console.WriteLine("Ваш логин сохранён. Поздравляю!!!");       
    }
    if (command == password)
    {
        if (log == String.Empty)
        {
            Console.WriteLine("Сначала создайте логин");
        }
        else
        {
        Console.Write($"введите ваш новый пароль для логина " + log + ": ");
        pass = Console.ReadLine();
        Console.WriteLine("Ваш парроль сменён удачно ");
        }
    }
    if (command == initialization) 
    {
        if (log == String.Empty)
        {
            Console.WriteLine("Сначала создайте логин и пароль ");
        }
        else
        {
            Console.WriteLine($"Ваш логин " + log );
        }
    }
    if (command == exit) break;
}
