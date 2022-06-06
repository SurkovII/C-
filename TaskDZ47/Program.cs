/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] getNumberArray(int m, int n, int range)
{
    double[,] result = new double[m, n];
    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * -range + range/2;
        }
    }
    return result;
}

void print2DArray(double[,] arrayToPrint)
{

    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(Math.Round(arrayToPrint[i, j], 1) + "\t");
        }
        Console.WriteLine();
    }
}

double[,] numberArray = getNumberArray(5, 5, 40);
print2DArray(numberArray);