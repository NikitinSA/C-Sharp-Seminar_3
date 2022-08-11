/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y)*/

void getCoordinateFromQuoter(int quoter)
{
    if (quoter == 1)
    {
        Console.WriteLine ("x > 0 и y > 0");
    }
    else if (quoter == 2)
    {
        Console.WriteLine ("x < 0 и y > 0");
    }
    else if (quoter == 3)
    {
        Console.WriteLine ("x < 0 и y < 0");
    }
    else if (quoter == 4)
    {
        Console.WriteLine ("x > 0 и y < 0");
    }
    else
    {
        Console.WriteLine ("Ошибка! Количество четвертей 4!");
    }
}

Console.WriteLine ("Введите четверть: ");
int quoter = Convert.ToInt32(Console.ReadLine());

getCoordinateFromQuoter(quoter);