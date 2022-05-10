/*Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray – первая 
добавляет к числовому массиву значение, 
тем самым увеличивая массив, а вторая удаляет элемент 
под нужным индексом и уменьшает массив на 1.
*/

Console.Write("Введите длинну массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];

AddToArray(array);
Console.WriteLine($"Длинна массива " + (array.Length+1));

Console.Write("Введите индекс массива который хотите удалить: ");
int remove = Convert.ToInt32(Console.ReadLine());

RemoveFromArray(ref array, remove);
Console.WriteLine($"Длинна массива " + (array.Length+1) + " удалился индекс " + remove);


void AddToArray(int[] array)//метод увилечения массива, и значение каждому индексу
{
    Array.Resize(ref array, array.Length+1);//увеличиваем длинну массива
    for ( int i = 0;i < array.Length;i++)
    {
        Console.WriteLine($"Дайте значение " + i + " индексу");
        array[i] = Convert.ToInt32(Console.ReadLine());// придаём значение числовому массиву
        Console.WriteLine($"Знчение " + i + " индекса = " + array[i]);
    }
}

void RemoveFromArray(ref int[] array, int index)// удаление из массива указанного индекса
{
    int[] newArray = new int[array.Length - 1];
    
    for ( int i = 0; i < index; i++ )
    {
        newArray[i] = array[i];
    }
    for ( int i = index + 1; i < array.Length; i++)
    {
        newArray[i - 1] = array[i]; 
    } 
}



