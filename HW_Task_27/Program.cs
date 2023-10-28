/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

Console.WriteLine("Введите число:");
string? value = Console.ReadLine();
int num = Convert.ToInt32(value);

int sum = 0;

while (num > 0)
{
    sum = sum + (num % 10);
    num = num / 10;

}

Console.WriteLine($"Сумма цифр в числе равна {sum}");
