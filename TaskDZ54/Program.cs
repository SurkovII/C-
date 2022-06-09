/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

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
    Console.WriteLine();

    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] averageColumnNumbers(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            int minPos = j;
            for (var z = j + 1; z < array.GetLength(1); z++)
            {
                while (array[i, z] < array[i, j])
                {
                    minPos = z;
                    int temp = array[i, j];
                    array[i, j] = array[i, minPos];
                    array[i, minPos] = temp;
                }

            }
        }
    }

    return array;
}

int[,] numberArray = getNumberArray(7, 7, 10);
print2DArray(numberArray);
Console.WriteLine();
int[,] newArray = averageColumnNumbers(numberArray);
print2DArray(newArray);
