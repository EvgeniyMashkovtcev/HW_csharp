﻿/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int numberM = ReadInt("Введите число M: ");
int numberN = ReadInt("Введите число N: ");

Console.Write(PrintSum(numberM, numberN));


int PrintSum(int M, int N)
{
    
    if (M == N)
        return N;
    else
        return M + PrintSum(M + 1, N);

}


int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
