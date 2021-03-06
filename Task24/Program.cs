/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

int GetSumOfSiries(int from, int to)
{
    int result = 0;
    for (var i = from; i <= to; i++)
    {
        result = result + i;  //result +=i
    }
    return result;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int SumOfSiries = GetSumOfSiries(1, number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {SumOfSiries}");