// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

Console.Clear();
Console.Write("Введите значение b1: ");
Double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
Double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
Double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
Double k2 = Convert.ToDouble(Console.ReadLine());

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Пересечение двух прямых: {x}, {y}");