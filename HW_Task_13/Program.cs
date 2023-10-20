/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число:");
string? value = Console.ReadLine();
int number = Convert.ToInt32(value);
int backup_number = number;

if (number < 100) 
{
    Console.WriteLine(number + " -> " + "Третьей цифры нет");
    return;
}

while (number > 999)
{
    number = number / 10;
}

int third_digit = number % 10;
Console.WriteLine(backup_number + " -> " + third_digit);
