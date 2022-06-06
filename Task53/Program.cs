/*Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.*/

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
    return array;
}

void printArray(int[,] arrayToPrint)
{
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] negativeArray(int[,] negArray)
{
    for (var i = 0; i < negArray.GetLength(0); i++)
    {
        int temp = negArray[negArray.GetLength(0) - 1, i];
        negArray[negArray.GetLength(0) - 1, i] = negArray[0, i];
        negArray[0, i] = temp;
    }
    return negArray;
}


int[,] array = GetArray(4, 4);
printArray(array);
Console.WriteLine();
int[,] negArray = negativeArray(array);
printArray(negArray);
