/*
Написать функцию Shuffle, которая перемешивает элементы массива в случайном порядке.
*/

int[] array = new int[5];
for ( int i = 0;i < array.Length;i++)
    {
        Console.WriteLine($"Дайте значение " + i + " индексу");
        array[i] = Convert.ToInt32(Console.ReadLine());// придаём значение числовому массиву
        Console.WriteLine($"Знчение " + i + " индекса = " + array[i]);
    }
void Shuffle(int[] arr)
{
    Random rand = new Random();// создаем экземпляр класса Random для генерирования случайных чисел
 
    for (int i = arr.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);
 
        int tmp = arr[j];
        arr[j] = arr[i];
        arr[i] = tmp;
    }
}
Shuffle(array);
var str = string.Join(" ", array);
Console.WriteLine(str);