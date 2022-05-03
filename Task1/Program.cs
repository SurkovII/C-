Console.Write("Введите число a ");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b ");

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA * numberA == numberB)
{
    Console.WriteLine("Да");
}

if (numberA * numberA != numberB) //else 
{
    Console.WriteLine("Нет");
}