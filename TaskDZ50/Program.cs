/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9*/

int[,] getNumberArray(int m, int n, int deviation)
{
    int[,] result = new int[m, n];
    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, deviation + 1);
        }
    }
    return result;
}

void print2DArray(int[,] arrayToPrint)
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

void GetPositionNumber(int[,] array, int positonNumber)
{

    if (array.GetLength(0) * array.GetLength(1) >= positonNumber)
    {
        int index1 = ((positonNumber - 1) % array.GetLength(0));
        int index2 = ((positonNumber - 1) / array.GetLength(1));
        Console.WriteLine($"Элемент позиции {positonNumber} равен {array[index2, index1]}");

    }
    else
    {
        Console.WriteLine("такого числа в массиве нет");
    }

}

Console.WriteLine("Введите число строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numberArray = getNumberArray(m, n, 10);
print2DArray(numberArray);
Console.WriteLine("Введите позицию числа ");
int positonNumber = Convert.ToInt32(Console.ReadLine());
GetPositionNumber(numberArray, positonNumber);