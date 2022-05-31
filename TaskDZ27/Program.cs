/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int GetSumNumber(int number)
{
    int result = 0;
    number = Math.Abs(number);
    while (number > 0)
    {
        int ost = number % 10;
        number = number / 10;
        result = result + ost;
    }
    return result;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber = GetSumNumber(number);


Console.WriteLine(SumNumber);