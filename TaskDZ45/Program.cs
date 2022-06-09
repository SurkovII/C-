/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

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

void copyNumbers(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Элемент массива под индексом {i} равен [{array[i]}]\t");
    }
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
copyNumbers(array);