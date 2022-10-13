/*
Условие задачи: 
Удалить вторую цифру трёхзначного числа

Автор: Трофимов П.А.
*/


//Методы
int HundToDec(string number)
{
    string[] temp = new string[2];
    for (int i = 0; i < number.Length; i = i + 2)
    {
        temp[i / 2] = number[i].ToString();
    }

    int result = Convert.ToInt32(String.Join(separator: null, temp));
    return result;
}

bool CheckNumber(string N)
{
    return int.TryParse(N, out int number);
}


//Программа

Console.WriteLine("Введите трехзначное число: ");
string test = Console.ReadLine();
if (CheckNumber(test))
{
    if ((int.Parse(test) > 99) && (int.Parse(test) < 1000))
    {
        Console.WriteLine($"Удалили вторую цифру: {HundToDec(test)}");
    }
    else
    {
        Console.WriteLine("Не является трехзначным числом.");
    }

}
else Console.WriteLine("Введенные символы не является числом!");


