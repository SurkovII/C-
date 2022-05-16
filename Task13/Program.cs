/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет*/

Console.Write("Введите первое число ");

int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");

int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne * numberOne == numberTwo || numberTwo * numberTwo == numberOne)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}