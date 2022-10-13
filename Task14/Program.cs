/*Условие задачи:
Найти третью цифру числа или сообщить, что её нет


Автор: Трофимов П.А.
*/

//Методы


bool CheckNumber(string N)
{
    return int.TryParse(N, out int number);
}

int ThirdDigit(string number)
{
    int result;
    int number_int = int.Parse(number);
    if (CheckNumber(number))
    {
        if (number_int >= 100)
        {
            result = (number_int / 100) % 10;
            return result;
        }
        else
        {
            Console.WriteLine("Третьей цифры не существует");
            result = -1;
            return result;
        }
    }
    else
    {
        Console.WriteLine("Введенный символ не является числом");
        result = -1;
        return result;
    }
}

