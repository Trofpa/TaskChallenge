/*Условия задачи:
21. Программа проверяет пятизначное число на палиндромом.

Автор: Трофимов П.А.

*/

//Методы
int InputNumber(string text)
{
    bool Condition = true;
    int number = 0;
    while (Condition)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out number)) Condition = false;
        else Console.WriteLine("Введенный символ не является числом!");
    }
    return number;
}

bool IsPalindrom(int number)
{
    int TempNumber = number / 10;
    int Reverse = number % 10;
    do
    {
        Reverse = Reverse * 10 + TempNumber % 10;
        TempNumber = TempNumber / 10;
    }
    while (TempNumber != TempNumber % 10);
    Reverse = Reverse * 10 + TempNumber % 10;
    return Reverse == number;
}


//Программа:
Console.Clear();
int N = InputNumber("Ввведите число: ");
if (IsPalindrom(N)) Console.WriteLine($"Число {N} является полиндромом!");
else Console.WriteLine($"Число {N} не является полиндромом!");