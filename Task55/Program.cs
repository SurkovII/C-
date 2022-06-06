/*Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/

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


void replaseArray(int[,] replaseArray)
{

    int[,] result = new int[replaseArray.GetLength(0), replaseArray.GetLength(1)];
    if (replaseArray.GetLength(0) == replaseArray.GetLength(1))
    {
        for (var i = 0; i < replaseArray.GetLength(0); i++)
        {
            for (var j = 0; j < replaseArray.GetLength(1); j++)
            {
                result[i, j] = replaseArray[j, i];
                Console.Write($"{result[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine($"Массив размером {replaseArray.GetLength(0)} х {replaseArray.GetLength(1)} невозможно перевернуть");
    }

}
int[,] array = GetArray(4, 4);
printArray(array);
Console.WriteLine();
replaseArray(array);
