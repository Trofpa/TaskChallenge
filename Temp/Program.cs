Console.WriteLine("Hello, World!");


int[] array1 = { 0, 1 };

int[] N = { 2 };

array1 = array1.Concat(N).ToArray();

Console.WriteLine(String.Join(" ", array1));


//алгоритм для задачи с магазином
// int[] time = { 1, 1, 1, 1, 4, 4, 1, 1, 1, 2, 3 };

// int max = time.Max();
// int s = Array.IndexOf(time, max); //ищет макс
// Console.WriteLine($"p: {s}");

// while (s != -1)
// {
//     int e = s;
//     for (int i = s; i < time.Length - 1; i++)s    
//     {
//         if(!(time[i] == time[i + 1]))
//         {
//             e = i;
//             break;
//         }
//     }
//     for (int i = 0; i <= e; i++)
//     {
        
//     }
// }

// int e = s;
// for (int i = s; i < time.Length - 1; i++)
// {
//     if (!(time[i] == time[i + 1]))
//     {
//         e = i; break;
//     }
// }
// Console.WriteLine($"{s}-{e}");

// //Потом обнуляем массив до первого интервала
// и по новой ищем тем же кодом(циклим)
