/* 
Условие задачи:
Вывести квадрат числа

 Автор: Трофимов П.А.
*/


using static System.Math;
using static System.Console;

Clear();
int a = InputNumbers("Введите число: ");
WriteLine($"Квадрат числа: {Pow(a, 2)}");


//Методы
int InputNumbers(string text)
{
    bool Condition = true;
    int number = 0;
    while (Condition)
    {
        Write(text);
        if (int.TryParse(ReadLine(), out number))
        {
            Condition = false;
        }
        else
        {
            WriteLine("Введенный символ не является числом!");
        }
    }
return number;
}