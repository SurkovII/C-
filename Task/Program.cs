int[,] generateArray(int colLength, int rowLength, int minBorder = 0, int maxBorder = 20)
{
    if (minBorder > maxBorder)
    {
        Console.WriteLine($"границы генерации не верны - минимальный больше максимального, minborder: {minBorder}, maxBorder: {maxBorder}");
        int buf = minBorder;
        minBorder = maxBorder;
        maxBorder = buf;
    }
    int[,] generatedArray = new int[colLength, rowLength];
    for (var i = 0; i < colLength; i++)
    {
        for (var j = 0; j < rowLength; j++)
        {
            generatedArray[i, j] = new Random().Next(minBorder, maxBorder + 1);
        }
    }
    return generatedArray;
}

void printHederOfNumbers(int length, string name = "")
{
    if (!string.IsNullOrEmpty(name))
    {
        Console.WriteLine($"----------{name}----------");
    }
    Console.Write("[ ]\t");
    for (var i = 0; i < length; i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
}
void print2DArray(int[,] arrayToPrint, string name = "")
{
    printHederOfNumbers(arrayToPrint.GetLength(1), name);
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void printArray(int[] array, string name = "")
{
    printHederOfNumbers(array.Length, name);
    Console.Write("[ ]\t");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

int[] getRowFrom2DArray(int[,] twoDArray, int rowIndex)
{
    int[] result = new int[twoDArray.GetLength(1)];

    for (var i = 0; i < twoDArray.GetLength(1); i++)
    {
        result[i] = twoDArray[rowIndex, i];
    }
    return result;
}
int[,] generatedArray = generateArray(7, 5, maxBorder: 100, minBorder:-20);
print2DArray(generatedArray, "Двухмерный мвссив");
const int rowIndex = 2;
int[] oneRow = getRowFrom2DArray(generatedArray, rowIndex);

printArray(oneRow, $"Строка двухмерного массива № {rowIndex}");
Console.WriteLine();