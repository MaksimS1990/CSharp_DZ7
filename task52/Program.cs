// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Программа задаёт двумерный массив и вычисляет среднее арифметическое элементов кадого столбца!");

Console.WriteLine("введите количество строк");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] array = CreateArray(rows, columns);
GetMeanOfColumns(array);
PrintArray(array);

int[,] CreateArray(int rows, int columns)
{
    Random random = new Random();

    int[,] array = new int[rows, columns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }

    return array;
}

void GetMeanOfColumns(int[,] array)
{
    for (var j = 0; j < array.GetLength(0); j++)
    {
        double sum = 0;
        for (var i = 0; i < array.GetLength(1); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Среднее арефметическое {j + 1} столбца {Math.Round(sum / array.GetLength(1), 1)} ");
    }
}


void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);

            if (j != array.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}