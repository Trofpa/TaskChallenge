/*
№27: Определить количество цифр в числе

Пример работы программы:
452 -> 3
82 -> 2
9012 -> 4

Автор: Трофимов П.А.
*/

//Методы:

int DiggitNumber(int number)
{
    string str = number.ToString();
    return str.Length;
}

int IntNumber(string text)
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


//Программа:
int N = IntNumber("Введите число: ");
Console.WriteLine($"Число содержит {DiggitNumber(N)} цифр");