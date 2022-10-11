// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Write("Ведите число: ");
int fist = Convert.ToInt32(Console.ReadLine());
int count = fist.ToString().Length;
Console.Write(MakeArray(fist, count));

int MakeArray(int a, int b)
{
int result = 0;
    if (b <= 2)
    {
        Console.Write("Нет третьего числа: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}