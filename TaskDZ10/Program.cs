/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.Write("Введите трехзначное число ");

int number = Convert.ToInt32(Console.ReadLine());

int numberOne = number / 10;
int numberTwo = numberOne % 10;

Console.Write($"У числа {number} вторая цифра ");
Console.WriteLine(numberTwo);
