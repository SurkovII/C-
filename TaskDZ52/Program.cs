/*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

void averageColumnNumbers(int[,] array)
{
  
    for (var j = 0; j < array.GetLength(1) ; j++)
    { 
        double sum = 0;
        double middle = 0;
        for (var i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        middle = Math.Round(sum/array.GetLength(1),1);
        Console.Write($"{middle}");

        if (j != array.GetLength(1)-1)
        {
            Console.Write("; ");
        }
        
    }
    
}

int[,] numberArray = getNumberArray(4, 4, 10);
print2DArray(numberArray);
Console.WriteLine();
averageColumnNumbers(numberArray);
Console.WriteLine();
