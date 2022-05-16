/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да*/

Console.Write("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());

/*int numberOne = number % 7;
int numberTwo = number % 23;
if (numberOne != 0)
{
    Console.WriteLine("нет");
}

if (numberTwo != 0)*/
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("да");
}

else
{ 
    Console.WriteLine("нет");
}

// Вместо двух if можно записать if (number % 7 == 0 && number % 23 == 0)