// Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Програма на вход принимает значение элемента в двумерном массиве и возвращает его позицию, либо сообщает, что такого элемента нет!");

Console.WriteLine("Введите искомое число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер строки");
int r = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца");
int c = int.Parse(Console.ReadLine()!);

int[,] array = CreateArray(r, c);

PrintArray(array);

if (GetResult(array)) Console.WriteLine("Искомого элемента нет в заданном массиве!");
else SearchDigit(array);

int[,] CreateArray(int r, int c)
{
    Random random = new Random();

    int[,] array = new int[r, c];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }

    return array;
}

bool GetResult(int[,] array)
{
    bool GetResult = true;
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
                return false;
        }
    }
    return GetResult;
}

void SearchDigit(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
                Console.WriteLine($"Искомое число расположено по индексу: [{i}, {j}]");
        }
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