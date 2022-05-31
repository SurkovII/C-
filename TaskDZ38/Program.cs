/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
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

int FindMaximumNumbers(int[] array)
{
    int Max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max)
        {
            Max = array[i];
        }
    }
    return Max;
}

int FindMinimumNumbers(int[] array)
{
    int Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < Min)
        {
            Min = array[i];
        }
    }
    return Min;
}


int[] array = new int[8];
FillArray(array);
PrintArray(array);
int Max = FindMaximumNumbers(array);
int Min = FindMinimumNumbers(array);
int result = Max - Min;
Console.WriteLine(result);