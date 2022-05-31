/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120*/

int GetProductNumbers(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {

        result = result * i;

    }
    return result;

}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int ProductNumbers = GetProductNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {ProductNumbers} ");