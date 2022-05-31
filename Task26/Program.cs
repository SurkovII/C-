/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int GetAmountNumbers(int InputNumber)
{
    int result = 1;
    while (InputNumber > 10)
    {
        InputNumber = InputNumber / 10;
        result++;

    }
    return result;

}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int AmountNumbers = GetAmountNumbers(number);
Console.WriteLine($"В числе {number} {AmountNumbers} цифры");