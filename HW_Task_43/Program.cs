/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями x = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());

// x = k1 * x + b1 -> (-b2 + b1)/(-k1 + k2)
// y = k2 * x + b2 -> k2 * x + b2

double X = -(b1 - b2) / (k1 - k2);
double Y = k1 * X + b1;

Console.Write($"Точка пересечения двух прямых: ({X}; {Y})");
