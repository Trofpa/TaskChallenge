/*
Показать числа от -N до N

Автор: Трофимов П.А.
*/


//Методы:

int[] NumbersArray(int number)
{
    int[] array = new int[2 * number + 1];
    number *= -1;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = number + i;
    }
    Console.WriteLine($"[" + String.Join(", ", array) + "]");
    return array;
}

int[] arr = NumbersArray(10);