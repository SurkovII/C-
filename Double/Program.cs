double[] GenerateArray(int length, int lowerBorder, int upperBorder)
{
    double[] result = new double[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = new Random().NextDouble() * upperBorder + lowerBorder;//
    }
    return result;
}

void PrintArray(double[] arrayToPrint, string name = "")
{
    Console.ForegroundColor = ConsoleColor.Green; //Задать цвет
    if (!string.IsNullOrEmpty(name))
    {
        Console.WriteLine($"Массив {name}");
    }
    Console.WriteLine("----------------------");
    Console.ForegroundColor = ConsoleColor.White;

    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayToPrint[i],2)); // Округление до 0,00
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("------------------");
    Console.WriteLine();
}
double[] arrayToPrint = GenerateArray(10,-50,100);
PrintArray(arrayToPrint);