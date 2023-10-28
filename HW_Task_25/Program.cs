/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using System.Xml.XPath;

Console.WriteLine("Введите основание:");
string? value_01 = Console.ReadLine();
int base_number = Convert.ToInt32(value_01);

Console.WriteLine("Введите показатель:");
string? value_02 = Console.ReadLine();
int indicator_number = Convert.ToInt32(value_02);

if (indicator_number < 0)
{
    Console.WriteLine("Показатель не может быть меньше нуля");
}
else 
{
    double result = Math.Pow(base_number, indicator_number);
    Console.WriteLine($"Число {base_number} в степени {indicator_number} равно {result}");
}
