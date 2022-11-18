// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
double[,] array = new double[m, n];
CreateArray(array);
PrintArray(array);

double[,] CreateArray(double[,] array)
{
    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.Next(-10, 10) + random.NextDouble(), 1);
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");

            if (j != array.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
