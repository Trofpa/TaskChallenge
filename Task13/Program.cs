/*
13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Автор: Трофимов П.А.

*/

//Методы:

bool CheckNumber(string N)
{
    return int.TryParse(N, out int number);
}


string IsEven(string number1, string number2)
{
    string result;
    if (CheckNumber(number1) && CheckNumber(number2))
    {
        int N1 = int.Parse(number1);
        int N2 = int.Parse(number2);
        if (N1 >= N2)
        {
            if (N1 % N2 == 0)
            {
                result = "true";
                return result;
            }

            else
            {
                result = $"{N1 % N2}";
                return result;
            }
        }
        else
        {
            if (N2 % N1 == 0)
            {
                result = "true";
                return result;
            }

            else
            {
                result = $"{N2 % N1}";
                return result;
            }
        }
    }
    else
    {
        result = "Неправильный ввод. Введите целые числа.";
        return result;
    }
}

//Программа

int Nbig = 25;
int Nsmall = 6;

Console.WriteLine(IsEven($"{Nbig}", $"{Nsmall}"));


