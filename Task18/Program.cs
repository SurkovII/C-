/*Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).*/

Console.WriteLine("Введите номер четверти от 1 до 4");
int quater = Convert.ToInt32(Console.ReadLine());

if (quater == 1)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти (x > 0 и y > 0)");
}
else if (quater == 2)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти (x < 0 и y > 0)");
}
else if (quater == 3)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти (x < 0 и y < 0)");
}
else if (quater == 4)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти (x < 0 и y > 0)");
}
else
{
    Console.WriteLine("Неверное число");
}