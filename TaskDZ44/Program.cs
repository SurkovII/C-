/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

int[] numbersFibonacci(int number)
{
    int[] result = new int[number];
    if (number == 1)
    {
        result[0] = 0;
    }
    if (number == 2)
    {
        result[1] = 1;
    }
    if (number > 2)
    {
        result[0] = 0;
        result[1] = 1;
        for (int i = 2; i < result.Length; i++)
        {
            result[i] = result[i - 2] + result[i - 1];
        }
    }
    return result;
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


Console.Write("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());

int[] fibonacciArray = numbersFibonacci(number);
PrintArray(fibonacciArray);