/*В переменной string есть секретное сообщение, 
во второй есть пароль. Пользователю программы 
даётся 3 попытки ввести пароль и увидеть секретное сообщение.
*/
Console.WriteLine("Есть секретное слово, узнаешь его если отгадаешь пароль. Всего 3 попытки");
//магическое слово petzl
Console.WriteLine("Могу дать подсказку, это используеться в промышленном альпинизме ");
string password = "rig";
int count = 1;
int final = 3;
while (count <= final)
{
    Console.WriteLine("Попытка №" + count +":");
    string attempt = Console.ReadLine();
    if (attempt == password)
    {
        Console.WriteLine("Поздравляю и секретное слово 'petzl'");
        break;
    }
    else
    { 
        Console.WriteLine("Неверно ");
    }
    count++;   
    
}
if (count > final) Console.WriteLine("Увы вам никогда не узнать секретное слово!))");

