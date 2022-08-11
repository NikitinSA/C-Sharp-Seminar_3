/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
 A (3,6); B (2,1) -> 5,09
 A (7,-5); B (1,-1) -> 7,21*/

void points_in_2D_space(double user_numberA1, double user_numberA2, double user_numberB1, double user_numberB2)
{
    double res1 = Math.Pow(user_numberB1 - user_numberA1,2);
    double res2 = Math.Pow(user_numberB2 - user_numberA2,2);
    double result = Math.Sqrt(res1 + res2);
    result = Math.Round(result,2);
    Console.WriteLine($"Расстояние между точками в 2D пространстве = {result}");
}

Console.WriteLine("Введите число A1: ");
double user_numberA1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число A2: ");
double user_numberA2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число B1: ");
double user_numberB1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число B2: ");
double user_numberB2 = Convert.ToDouble(Console.ReadLine());

points_in_2D_space(user_numberA1, user_numberA2, user_numberB1, user_numberB2);