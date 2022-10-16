/*
31. Задать массив из 8 элементов и вывести их на экран 

Автор: Трофимов П.А.
*/

//Методы:
//Генерация 1-мерного массива
int[] GenArray(int Nelements, int min = 0, int max = 100)
{
    int[] array = new int[Nelements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(min, max + 1);
    }
    return array;
}

//Программа
Console.WriteLine($"\n[{String.Join(", ", GenArray(8))}]\n");