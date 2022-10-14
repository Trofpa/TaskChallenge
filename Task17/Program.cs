/* Условие задачи:
По двум заданным числам проверять является ли одно квадратом другого

Автор: Трофимов П.А.

*/

//Методы

bool SquareBond(double a, double b)
{
    bool result;
    if((Math.Pow(a, 2) == b) || (Math.Pow(b, 2) == a))
    {
        result = true;
        return result;
    }
    else
    {
        result = false;
        return result;
    }
}


//Программа

int A = 3209;
int B = 4;

if(SquareBond(A, B))
{
    if(A > B) Console.WriteLine($"{A} является квадратом {B}");
    else  Console.WriteLine($"{B} является квадратом {A}");
}
else Console.WriteLine($"{A} не является квадратом {B} и наоборот");
