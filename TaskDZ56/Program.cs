/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

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

int[] getSumRowNumbers(int[,] array)

{
    int[] sumRowNumberArray = new int[array.GetLength(0)];
    for (var i = 0; i < array.GetLength(0); i++)
    {

        for (var j = 0; j < array.GetLength(1); j++)
        {
            sumRowNumberArray[i] += array[i, j];
        }


    }
    return sumRowNumberArray;

}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

void SetMinRow(int[] array)
{
    int MinRow = array[0];
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < MinRow)
        {
            MinRow = array[i];
            result = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {result}");
}


int[,] numberArray = getNumberArray(5, 5, 10);
print2DArray(numberArray);
Console.WriteLine();
int[] sumRowNumberArray = getSumRowNumbers(numberArray);
PrintArray(sumRowNumberArray);
Console.WriteLine();
SetMinRow(sumRowNumberArray);