Console.Write("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());

/*
if (number == 1)
{
    Console.WriteLine("Понедельник");
}
if (number == 2)
{
    Console.WriteLine("Вторник");
}
if (number == 3)
{
    Console.WriteLine("Среда");
}
if (number == 4)
{
    Console.WriteLine("Четверг");
}
if (number == 5)
{
    Console.WriteLine("Пятница");
}
if (number == 6)
{
    Console.WriteLine("Суббота");
}
if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
else //if(number>= 8);
{
    Console.WriteLine("Неверное число ");
}
*/
switch(number)
{
    case 1:
        {
            System.Console.WriteLine("Понедельник");
            break;
        }
    case 2:
        {
            System.Console.WriteLine("Вторник");
            break;
        }
    case 3:
        {
            System.Console.WriteLine("Среда");
            break;
        }
    case 4:
        {
            System.Console.WriteLine("Четверг");
            break;
        }
    case 5:
        {
            System.Console.WriteLine("Пятница");
            break;
        }
    case 6:
        {
            System.Console.WriteLine("Суббота");
            break;
        }
    case 7:
        {
            System.Console.WriteLine("Воскресенье");
            break;
        }
    default:
        {
            System.Console.WriteLine("Дней недели всего 7");
            break;
        }
}