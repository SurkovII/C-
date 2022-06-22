/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
eДаны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9*/

int functionAkkerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberN == 0)
    {
        return functionAkkerman(numberM - 1, 1);
    }
    else
    {
        return functionAkkerman(numberM - 1, functionAkkerman(numberM, numberN - 1));
    }

}

Console.WriteLine(functionAkkerman(2, 3));