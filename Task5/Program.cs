/*Условие задачи:
Написать программу вычисления значения функции  
`y = f(a) = Sin(a + Cos(1 / a))`  +  график

Автор: Трофимов П.А.
*/

using static System.Console;
using static System.Math;


//Программа:
Clear();
double number = GetValue("Введите точку 'a' на функции Sin(a + Cos(1 / a))");
double func = GetFunction(number);
WriteLine($"Значение функции: {func}");

ShowGraph();


//Методы:
//Считаем функцию
double GetFunction(double arg)
{
    double result = (Sin(arg + Cos(1/arg)));
    return result;
}

// Запрашиваем у пользователя значения аргумента и запоминаем значение в переменную
double GetValue(string text) 
{
    Write(text + " : ");
    double value = Convert.ToDouble(ReadLine());
    return value;
}


//Метод для графика
void ShowGraph()
{
Clear();
int points = 100;
for (int i = 1; i < points; i = i + 1)
{
    SetCursorPosition(i, Convert.ToInt32(15 - Round(2 * GetFunction(i))));
    Write("*");
}
SetCursorPosition(0, 20);
ReadLine();
}
