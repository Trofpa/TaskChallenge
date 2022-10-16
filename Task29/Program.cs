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
    if(number == 1 || number == 0) return 1;
    else return number * Fact(number - 1);
}

//Программа
int N = InputNumber("Введите число: ");
Console.WriteLine($"{N}! = {Fact(N)}");
