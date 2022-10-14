/* Условие задачи:
25. Найти сумму чисел от 1 до А

Автор: Трофимов П.А.

*/

//Методы

int Sum(int a)
{
    int result = 0;
    for(int i = 1; i < a + 1; i++)
    {
        result += i;
    }
    return result;
}

int IntInput(string text)
{
    int number = 0;
    Console.WriteLine(text);
    if(!(int.TryParse(Console.ReadLine(), out number)))
    {
        Console.WriteLine("Введенный символ не является целым числом!");
        number = -1;
        return number;
    }
    else return number;
}

//Программа

int N = IntInput("Введите целое число: ");
Console.WriteLine($"Сумма числе от 1 до {N} равна {Sum(N)}");

