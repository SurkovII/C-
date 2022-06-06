/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

int[,] getNumberArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

void print2DArray(int[,] arrayToPrint)
{

    Console.Write($"[ ]\t");
    for (var i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i+1}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write("[" + (i+1) + "]\t");
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numberArray = getNumberArray(m, n);
print2DArray(numberArray);