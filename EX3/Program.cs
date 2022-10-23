// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, double min, double max)
{

    var array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double rmd = rnd.NextDouble()* (max - min) + min;
        array[i] = Math.Round(rmd, 1, MidpointRounding.ToZero);
    }
    return array;
}

double DubleRaz(double[] array)
{
    double maxFillarray = array[0];
    double minFillarray = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxFillarray) maxFillarray = array[i];
        else if (array[i] < minFillarray) minFillarray = array[i];
    }

    return maxFillarray - minFillarray;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; "); 
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}   

double[] arr = CreateArrayRndDouble(4, 3, 7); 
PrintArrayDouble(arr);

double des = Math.Round(DubleRaz(arr), 1, MidpointRounding.ToZero);
Console.WriteLine($"Максимальное значение массива -> {des}");