/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

int[] getArray(int numberLength)
{
    
    int[] result = new int[numberLength];
    for (var i = 0; i < numberLength; i++)
    {
        Console.Write("Введите число ");
        result[i] = Convert.ToInt32(Console.ReadLine());

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

int positiveNumbers(int[] arrayUser)
{
    int count = 0;
    for (var i = 0; i < arrayUser.Length; i++)
    {
        if (arrayUser[i] > 0)
        {
            count++;
        }
        
    }
    return count;

}

Console.Write("Введите число желаемоемых чисел массива ");
int numberLength = Convert.ToInt32(Console.ReadLine());
int[] array = getArray(numberLength);
PrintArray(array);
int positiveNumber = positiveNumbers(array);
Console.WriteLine($"Пользователь ввел положительных чисел - {positiveNumber}");