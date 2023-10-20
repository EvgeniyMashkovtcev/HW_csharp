/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число:");
string? value = Console.ReadLine();
int number = Convert.ToInt32(value);

if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число");
    return;
}

int second_digit = (number / 10) % 10;

Console.Write(number + " -> " + second_digit);
