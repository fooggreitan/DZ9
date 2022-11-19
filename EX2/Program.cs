// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите целовен число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целовен число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int SumDigitsForward(int numOne, int numTwo)
{
    if (numTwo == numOne)
    {
        return numOne = numOne + SumDigitsForward(numOne + 1, numTwo);
    }

    if (numOne > numTwo || numTwo == 0) return 0;
    {
        return numOne + SumDigitsForward(numOne + 1, numTwo);
    }
}

int SumDigitsBackward(int numOne, int numTwo)
{
    if (numTwo > numOne || numTwo == 0) return 0;
    {
        return numOne = numOne + SumDigitsBackward(numOne - 1, numTwo);
    };
}

if (numberOne > numberTwo)
{
    int sumDigitsBackward = SumDigitsBackward(numberOne, numberTwo);
    Console.WriteLine($"Cумму натуральных элементов в промежутке от {numberOne} до {numberTwo} = {sumDigitsBackward}");
}
else
{
    int sumDigitsForward = SumDigitsForward(numberOne, numberTwo);
    Console.WriteLine($"Cумму натуральных элементов в промежутке от {numberOne} до {numberTwo} = {sumDigitsForward}");
}