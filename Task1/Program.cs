/* Условие задачи:
По двум заданным числам проверять является ли первое квадратом второго

Автор: Трофимов П.А. */

//Программа
using static System.Console;
using static System.Math;


Clear();
int[] numbers = {0, 0}; // пример задания цикла явными числами
for (int i = 0; i < 2; i++) // пример использования цикла for
{
    numbers[i] = InputNumbers($"Введите число {i+1}: ");
}
if (IsSquare(numbers))
{
    WriteLine($"{numbers[0]} является квадратом числа {numbers [1]} !");
}
else
{
    WriteLine($"{numbers[0]} не является квадратом числа {numbers [1]} !");
}

//Методы:

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


bool IsSquare(int[] array)
{
    return Sqrt(array[0]) == array[1];
}