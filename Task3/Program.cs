/* Условие задачи:
По заданному номеру дня недели вывести его название

Автор: Трофимов П.А.
*/

//Программа:
Console.Clear();
int DayNumber = InputDay("Введите номер дня недели: ");
DayOfWeek(DayNumber);

int InputDay(string text) // Взял образец из Task15
{
    int number = 0;
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number > 7)
            {
                if (number == 0)
                {
                    
                }
                else
                {
                    Console.WriteLine("В неделе семь дней, валенок (-_-)");
                }
                
            }
            else
            {
                if (number <= 0)
                {
                    if (number == 0)
                    {
                        Console.WriteLine("Ага, нулевой день недели, а как же (-_-)");
                    }
                    else
                    {
                        Console.WriteLine("Отрицательные дни недели? Мдаааа Попробуй еще раз (-_-)");
                    }
                }
                else
                {
                break;
                }
            }
        }
        else
        {
            Console.WriteLine("Введенный символ не является числом!");
        }
    }
return number;
}

void DayOfWeek(int day)
{
    switch (day)
    {
        case 1: 
            Console.WriteLine("Понедельник! (Т_Т)");
            break;
        case 2: 
            Console.WriteLine("Вторник! (-_-)");
            break;
        case 3: 
            Console.WriteLine("Среда! (О_О)");
            break;
        case 4: 
            Console.WriteLine("Четверг!(-_-)");
            break;
        case 5: 
            Console.WriteLine("Пятница! (*_*)");
            break;
        case 6: 
            Console.WriteLine("Суббота! (^_^)");
            break;
        default: 
            Console.WriteLine("Воскресенье! (^_^)");
            break;
    }
}