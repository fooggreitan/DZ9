// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArrayRndInt(int row, int columns, int min, int max)
{
    var array = new int[row, columns];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

double[] CreateArrayRndIn(int[,] array)
{
    double[] avg  = new double[array.GetLength(1)];
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = default;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }

        avg[j] = Math.Round(sum / array.GetLength(0), 1);
    }

    return avg;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],6}, "); // форматирование
            else Console.Write($"{array[i, j],6}"); // форматирование
        }
        Console.WriteLine("]");
    }
}

int[,] arrat2D = CreateArrayRndInt(3, 4, 1, 100);
PrintArray(arrat2D);

double[] avg = CreateArrayRndIn(arrat2D);
Console.WriteLine($"{avg[0],6}; {avg[1],6}; {avg[2],6}; {avg[3],6}");
