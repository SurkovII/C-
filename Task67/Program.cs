/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/
/*
void SumNubmers(int number, int sum = 0)
{
    if (number == 0)
    {
        Console.WriteLine(sum);
    }
    else if (number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
        SumNubmers(number, sum);
    }
}

SumNubmers(45);
*/
int digitsSum(int number)
{
    if (number == 0) return 0;
    return number % 10 + digitsSum(number / 10);
}

int number = digitsSum(546);
Console.WriteLine(number);