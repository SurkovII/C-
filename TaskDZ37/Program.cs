/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

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


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void ProductOfNumbers(int[] array)
{
    Console.Write("[");
    int index = 0;

    while (index < array.Length / 2)
    {
        if (array.Length % 2 == 0)
        {

            array[index] = array[index] * array[array.Length - 1 - index];
            Console.Write(array[index]);
            if (array.Length / 2 - 1 != index)
            {
                Console.Write(", ");
            }
            index++;
        }
        else if (array.Length % 2 != 0)
        {
            for (index = 0; index < array.Length / 2; index++)
            {
                array[index] = array[index] * array[array.Length - 1 - index];
                Console.Write(array[index]);
                if (array.Length / 2 != index)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(array[array.Length / 2]);
        }

    }
    Console.WriteLine("]");
}


int[] array = new int[9];
FillArray(array);
PrintArray(array);
ProductOfNumbers(array);