// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа т и п.
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите целовен число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целовен число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int SumDigits(int numOne, int numTwo)
{
    if (numOne == 0)
    {
        return numTwo + 1;
    }
    
    if (numOne > 0 && numTwo == 0)
    {
        return SumDigits(numOne - 1, 1);
    }
    return SumDigits(numOne - 1, SumDigits(numOne, numTwo - 1));
}

int result = SumDigits(number1, number2);
Console.WriteLine($"A({number1},{number2}) = {result}");