/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координату X точки A ");
int XdotA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A ");
int YdotA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X точки B ");
int XdotB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B ");
int YdotB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((XdotA - XdotB) * (XdotA - XdotB) + (YdotA - YdotB) * (YdotA - YdotB));

Console.WriteLine($"расстояние между точками А и B " + Math.Round(distance, 2));