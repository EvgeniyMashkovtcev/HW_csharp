/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/



int number = ReadInt("Введите число: ");
PrintNumbers(number);


void PrintNumbers(int N)
{
    if (N == 0)
        return;

    Console.Write(N + " ");
    PrintNumbers(N - 1);

}



int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
