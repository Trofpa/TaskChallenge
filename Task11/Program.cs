/*Условие задачи:
Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

Автор: Трофимов П.А.
*/

//Методы

int BiggestDigit(int number)
{
    string str = number.ToString();
    int max = 0;
    foreach (char i in str)
    {
        if(int.Parse(i.ToString()) > max) max = int.Parse(i.ToString());
    }
    return max;
}


//Программа
int N = new Random().Next(10, 10000000);
Console.WriteLine($"Дано число: {N}");
Console.WriteLine($"Наибольшая цифра: {BiggestDigit(N)}");
