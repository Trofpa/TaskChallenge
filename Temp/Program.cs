Console.WriteLine("Hello, World!");

int[] array = Array.Empty<int>();

int N = 2;

Array.Resize(ref array, 1);
array.SetValue(N, 0);

Console.WriteLine(String.Join(" ", array));


