/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

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

int GetSumNumbersDiagonal(int[,] array)
{
    int result = 0;
    for (var i = 0; i < array.GetLength(0) ; i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + array[i,j];
            }
        }
    }
    return result;
}

int[,] numberArray = getNumberArray(4, 4, 10);
print2DArray(numberArray);
Console.WriteLine();
int result = GetSumNumbersDiagonal(numberArray);
Console.WriteLine(result);