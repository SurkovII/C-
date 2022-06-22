/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int NaturalNumbersMN(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber)
    {
        return firstNumber;
    }
    else
    {
        return firstNumber = firstNumber + NaturalNumbersMN(firstNumber + 1, secondNumber);
    }
}

Console.WriteLine(NaturalNumbersMN(4, 8));