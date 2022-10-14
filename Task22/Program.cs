/*Условия задачи:
22. Найти расстояние между точками в пространстве 2D/3D

Автор: Трофимов П.А.

*/

//Методы

int[] InputCoordinates(string text)
{
    bool Condition = true;
    int[] array = new int[3];
    for (int i = 0; i < array.Length; i++)
    {
        switch (i)
        {
            case 0:
                array[i] = InputNumber($"Введите координату X точки {text}: ");
                break;
            case 1:
                array[i] = InputNumber($"Введите координату Y точки {text}: ");
                break;
            case 2:
                array[i] = InputNumber($"Введите координату Z точки {text}: ");
                break;
        }

    }
    return array;
}

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

double GetDistance(int[] a, int[] b)
{
    double sum = 0;
    double result;
    for (int i = 0; i < a.Length; i++)
    {
        sum += Math.Pow(a[i] - b[i], 2);
    }
    result = Math.Sqrt(sum);
    return result;
}

//Программа

//Вводим координаты точек A и B:
int[] Point1 = InputCoordinates("A");
int[] Point2 = InputCoordinates("B");

//Считаем расстояние и выводим ответ:
double distance = GetDistance(Point1, Point2);

Console.WriteLine($"А ({Point1[0]}, {Point1[1]}, {Point1[2]});"
                + $"B ({Point2[0]}, {Point2[1]}, {Point2[2]})"
                + $"-> {distance:F2}");

