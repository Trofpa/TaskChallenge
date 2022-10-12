/*
Показать последнюю цифру трёхзначного числа


Автор: Трофимов П.А.

*/

//Методы

int ThirdDigit(int number)
{
    int result;
    int temp = 0;
    if ((number >= 100 ) && (number < 1000))
    {
        result = number % 10;
    }
    else
    {
        Console.WriteLine("Не трехзначное число!");
        result = -1;
    }
    return result;
}

int N = 465;
Console.WriteLine(ThirdDigit(N));
