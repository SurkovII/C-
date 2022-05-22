/*Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/

int GetNumberOfQuater(int X, int Y)
{
    int result = 0;
    if (X > 0 && Y > 0)
    {
        result = 1;
    }
    else if (X < 0 && Y > 0)
    {
        result = 2;
    }
    else if (X < 0 && Y < 0)
    {
        result = 3;
    }
    else if (X > 0 && Y < 0)
    {
        result = 4;
    }
    return result;
}
void ShowQuated(int X, int Y)
{
    int quater = GetNumberOfQuater(X, Y);
    if (quater > 0)
    {
        Console.WriteLine($"Точка [{X}:{Y}] находится в {quater} четверти");
    }
    else
    {
        Console.WriteLine($"Точка [{X}:{Y}] находится на пересечении четвертей");
    }
}

ShowQuated(1, 1);
ShowQuated(-1, 1);
ShowQuated(-1, -1);
ShowQuated(1, -1);
ShowQuated(1, 0);
ShowQuated(0, 1);
ShowQuated(0, 0);

/*
Console.WriteLine("Введите X ");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y ");
int userY = Convert.ToInt32(Console.ReadLine());

int quater = GetNumberOfQuater(userX, userY);
if (quater > 0) 
{
    Console.WriteLine($"Точка [{userX}:{userY}] находится в {quater} четверти");
}
else
{
    Console.WriteLine($"Точка [{userX}:{userY}] находится на пересечении четвертей");
}
*/