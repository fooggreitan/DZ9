// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int c;

    if (number < 100)
    {
        Console.Write("Третьей цифры нет ");
    }
    else if (number < 1000)
    {
        c = number % 10;
        Console.Write($"Третье число:{c}");
    }
    else if (number < 10000)
    {
        c = (number % 100 - number % 10)/10;
        Console.Write($"Третье число:{c}");
    }
    else if (number < 100000)
    {
        c = (number % 1000 - number % 100)/100;
        
        Console.Write($"Третье число:{c}");
    }
    
    else
    {
        c = number % 10;
        Console.Write($"Третье число:{c}");
    }
