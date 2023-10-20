/*  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру дня недели:");
string? value = Console.ReadLine();
int week_day = Convert.ToInt32(value);

if (week_day <= 0 || week_day > 7)
{
    Console.WriteLine("В неделе семь дней");
    return;
}

if (week_day > 5)
{
    Console.WriteLine(week_day + " -> " + "да");
    return;
}

if (week_day <= 1 || week_day >= 5)
{
    Console.WriteLine(week_day + " -> " + "нет");
    return;
}
