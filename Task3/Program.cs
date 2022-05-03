/* Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"*/

Console.Write("Введите число ");

int N = Convert.ToInt32(Console.ReadLine());
/*
int InvertN = -N;

while(InvertN <= N)
{
    Console.Write(InvertN);
    InvertN ++;
    if (InvertN <= N)
    {
        Console.Write(", ");
    }

}
Console.WriteLine();
*/

for (int i=-N; i<=N; i++)
{
    Console.Write(i);
    if (i != N)
    {
    Console.Write(", ");
    }

}
Console.WriteLine();