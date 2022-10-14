/* Условие задачи:
Определить номер четверти плоскости,в которой находится
точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


Автор: Трофимов П.А.

*/

//Методы

int Quarter(double[] array)
{
    int result = -1;
    if ((array[0] == 0) || (array[1] == 0))
    {
    }
    else
    {
        if (array[0] > 0)
        {
            if (array[1] > 0) result = 1;
            else result = 4;
        }
        else
        {
            if (array[1] > 0) result = 2;
            else result = 3;
        }
    }
    return result;
}

double[] InputPoints()
{
    double[] result = new double[2];
    Console.WriteLine("Введите коордианты X, Y точки: ");
    string input = Console.ReadLine();
    string[] temp = input.Split(", ", 2);
    for (int i = 0; i < temp.Length; i++)
    {
        result[i] = Convert.ToDouble(temp[i]);
    }
    return result;
}

//Программа

double[] Points = InputPoints();
if(Quarter(Points) == -1) Console.WriteLine("Точка на оси");
else Console.WriteLine($"Введенная точка в {Quarter(Points)} четверти");


