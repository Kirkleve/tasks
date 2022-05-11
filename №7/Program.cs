/*
Написать программу со следующими командами:

- SetNumbers – пользователь вводит числа через пробел, а программа запоминает их в массив
- AddNumbers – пользователь вводит числа, которые добавятся к уже существующему массиву
- RemoveNumbers - пользователь вводит числа, которые если найдутся в массиве, то будут удалены
- Numbers – ввывод текущего массива
- Sum – найдется сумма всех элементов чисел
*/

void Numbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SetNumbers()
{
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

void AddNumbers(int[] numbers)
{

    int[] sum = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int[] newNumbers = new int[numbers.Length + sum.Length];
    var result = numbers.Union(sum);

    foreach (int s in result)
        Console.Write(s);
}

void RemoveNumbers(int[] array, int remove)
{
    int[] newArray = array.Except(new int[] { remove }).ToArray();
}

int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int remove = Convert.ToInt32(Console.ReadLine());
RemoveNumbers(numbers, remove);
Sum(numbers);

void Sum(int[] array)
{
    int rez = array.Sum();
    Console.WriteLine(rez);
}


