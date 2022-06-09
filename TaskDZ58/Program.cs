/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

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

int[,] multiplicationMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] multiMatrix = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            multiMatrix[i, j] = matrixOne[i, j] * matrixTwo[i, j];
        }
    }
    return multiMatrix;
}


int[,] numberMatrixOne = getNumberArray(5, 4, 10);
print2DArray(numberMatrixOne);
Console.WriteLine();

int[,] numberMatrixTwo = getNumberArray(5, 4, 10);
print2DArray(numberMatrixTwo);
Console.WriteLine();

int[,] multiMatrix = multiplicationMatrix(numberMatrixOne, numberMatrixTwo);
print2DArray(multiMatrix);