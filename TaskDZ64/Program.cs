/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4"*/

void NaturalNumbersMN(int firstNumber, int secondNumber)
{
    if (firstNumber < secondNumber)
    {
        return;
    }
    else
    {
        Console.Write(firstNumber);
        if (firstNumber > secondNumber)
        {
            Console.Write(", ");
        }
        NaturalNumbersMN(firstNumber - 1, secondNumber);
    }
}
NaturalNumbersMN(5, 1);