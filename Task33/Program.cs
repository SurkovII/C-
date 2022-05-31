/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

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

bool DetectNumber(int[] array, int putnumber)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == putnumber)
        {
            result = true;
            break;
            
        }

        
    }
    return result;

}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
bool HasNumber =  DetectNumber(array, 5);
Console.WriteLine((HasNumber)?"Да":"Нет");