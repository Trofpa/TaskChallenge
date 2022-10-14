/*Условие задачи
23. Показать таблицу квадратов чисел от 1 до N 

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

//Возвращение таблицы чисел в степени:
double[] Times(int number, int power)
{
    double[] array = new double[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = Math.Pow(i + 1, power);
    }
    return array;
}


//Программа:
int N = InputNumber("Введите число: ");
double[] res = Times(N, 2);
string output = $"{N} -> ";

for (int i = 0; i < res.Length; i++)
{
    if (i == res.Length - 1) output += $"{res[i]}";
    else output += $"{res[i]}, ";
}
Console.WriteLine(output);



