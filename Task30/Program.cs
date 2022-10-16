/*
№30: Показать кубы чисел, заканчивающихся на четную цифру

Автор: Трофимов П.А.
*/

//Методы:

//Ввод числа:
int InputNumber(string text)
{
    bool Condition = true;
    int number = 0;
    while (Condition)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            Condition = false;
        }
        else
        {
            Console.WriteLine("Введенный символ не является числом!");
        }
    }
    return number;
}

//Генерация 1-мерного массива
int[] GenArray(int Nelements, int min, int max)
{
    int[] array = new int[Nelements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(min, max + 1);
    }
    return array;
}

//Метод для показа кубов
double[] Cubes(int[] array)
{
    List<double> cubes = new List<double>();
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        temp = array[i] % 10;
        if (temp % 2 == 0)
        {
            cubes.Add(Math.Pow(array[i], 3));
        }
    }
    if (cubes.Count == 0) cubes.Add(-1);
    double[] result = cubes.ToArray();
    return result;
}

int[] array1 = GenArray(5, 11, 24);
//int[] array1 = { 3, 5 };
double[] array2 = Cubes(array1);
Console.WriteLine($"\n[{String.Join(", ", array1)}] -> "
                + $"[{String.Join(", ", array2)}]\n");


