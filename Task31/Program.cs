﻿/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

int[] GetRundomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int sumElementsOfArray(int[] arrayToCalculate, int multiply)
{
    int result = 0;
    for (var i = 0; i < arrayToCalculate.Length; i++)
    {
        if (arrayToCalculate[i] * multiply > 0)
        {
            result = result + arrayToCalculate[i];
        }
    }
    return result;
}

int[] randomArray = GetRundomArray(12, 9); 
int positiveSumOfArray = sumElementsOfArray(randomArray, 1);
int negativeSumOfArray = sumElementsOfArray(randomArray, -1);

PrintArray(randomArray);
Console.WriteLine($"Сумма положительных чисел равна {positiveSumOfArray}, сумма отрицательных равна {negativeSumOfArray}");
