/*
№29: Написать программу вычисления произведения чисел от 1 до N*

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

//Вычисление факториала

int Fact(int number)
{
    int fact = 1;
    for (int i = 2; i < number + 1; i++)
    {
        fact *= i;
    }
    return fact;
}

//Программа
int N = InputNumber("Введите число: ");
Console.WriteLine($"{N}! = {Fact(N)}");
