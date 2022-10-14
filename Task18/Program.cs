/* Условие задачи:
Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y\

Автор: Трофимов П.А.

*/

//Методы

bool thesis()
{
    bool[] b1 = {false, true};
    bool[] b2 = {false, true};
    bool condition = true;
    foreach(bool i in b1)
    {
        foreach(bool j in b2)
        {
            Console.WriteLine($"(!({b1} || {b2}) == (!{b1} && !{b2}))");
            if (!(i || j) == (!i && !j))
            {
                continue;
            }
            else
            {
                condition = false;
                break;
            }
        }
    }
    return condition;
}

//Программа


if (thesis()) Console.WriteLine("Утверждение ¬(X ⋁ Y) = ¬X ⋀ ¬Y истинно!");
else Console.WriteLine("Утверждение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ложно!");