/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/

int rundomNumber = new Random().Next(100, 1000);
int numberOne = rundomNumber % 10;
int numberTwo = rundomNumber / 100;
Console.WriteLine(rundomNumber);
Console.Write($"У числа {rundomNumber} первая и последняя цифры составляют ");
Console.Write(numberTwo);
Console.WriteLine(numberOne);