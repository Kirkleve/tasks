/*Есть программа с бесконечным циклом. 
Когда пользователь вводит exit программа заканчивается
*/
int i = 0;
for (; ; )
{
    i++;
    Console.WriteLine(i);
    string? exitWord = Console.ReadLine();
    string word = "exit";
    if (exitWord == word)
    {
        break;
    }
}