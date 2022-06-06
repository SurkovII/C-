/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

int numberChange(int number)
{
    int count = 0;
    int result = 0;
    while (number > 0)
    {
        int decimai = number % 2;
        result = result + decimai * Convert.ToInt32(Math.Pow(10, count));
        number = number / 2;
        count++;
    }
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = numberChange(number);
Console.WriteLine($"Десятичное число {number} равно двоичному {result}");



/*string numberChange(int number)
{
    string result = "";
    int temp = 0;
    for (var i = number; i > 0; i /= 2)
    {
        temp = i % 2;
        result = temp + result;
    }
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string result = numberChange(number);
Console.WriteLine(result);*/
