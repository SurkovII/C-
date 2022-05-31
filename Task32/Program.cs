/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void NegativeArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}

int[] array1 = new int[4];
FillArray(array1);
PrintArray(array1);
NegativeArray(array1);
PrintArray(array1);