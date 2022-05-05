/*Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray – первая 
добавляет к числовому массиву значение, 
тем самым увеличивая массив, а вторая удаляет элемент 
под нужным индексом и уменьшает массив на 1.
*/

Console.Write("Введите длинну массива: ");
int[] array = new int[5];
Array.Resize(ref array, array.Length+1);
array[array.Length-1] = 8;

Console.WriteLine(array.Length);
/*
int[] AddToArray(int[] mass)
        {
            Array.Resize(ref mass, mass.Length+1);
            mass[mass.Length-1] = 8;
        }


void MakeArray (int[] meaning)
{
    for ( int i = 0;i < array.Length;i++)
    {
        Console.Write("Введите длинну массива: ");
        meaning = new int[Convert.ToInt32(Console.ReadLine())];
        Console.WriteLine("Введите значение массива: ");
        meaning[i] = Convert.ToInt32(Console.ReadLine());
    }
}*/