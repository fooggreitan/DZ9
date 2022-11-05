// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArrayRndInt(int row, int columns, double min, double max)
{
    var array = new double[row, columns];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble(), 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{  
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i,j], 6}, "); // форматирование
            else Console.Write($"{array[i,j], 6}"); // форматирование
        }
        Console.WriteLine("]");
    }
}

double[,] array2D = CreateArrayRndInt(3, 4, 1, 100);
PrintArray(array2D);
