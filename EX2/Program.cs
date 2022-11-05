// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[] meaningNumbersArray = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

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

bool CheckingPositions(int[,] array)
{
    if (meaningNumbersArray[0] < array.GetLength(0) && meaningNumbersArray[1] < array.GetLength(1)) return true;
    else return false;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 4}, "); // форматирование
            else Console.Write($"{array[i, j], 4}"); // форматирование
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateArrayRndInt(3, 4, 1, 100);
PrintArray(array2D);

bool сheckingPositions = CheckingPositions(array2D);

if (сheckingPositions) Console.WriteLine($"{array2D[meaningNumbersArray[0], meaningNumbersArray[1]]}");
else Console.WriteLine("Такого элемента в массиве нет");
