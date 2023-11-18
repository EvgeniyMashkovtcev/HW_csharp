/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

using System.Threading.Tasks.Dataflow;

Console.Write("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[M];

void CreatingАrray(int m)
    {
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Введите {i + 1} элемент массива: ");
            Array[i] = Convert.ToInt32(Console.ReadLine());
        }

    }

int Сount(int[] Array)
{
    int i=0;
    int sum = 0;

    while (i < Array.Length)
    {
        if(Array[i] > 0)
        sum = sum + 1;
        i = i + 1;
    }

return sum;
}

CreatingАrray(M);
Console.Write($"Чисел больше нуля: {Сount(Array)}");
