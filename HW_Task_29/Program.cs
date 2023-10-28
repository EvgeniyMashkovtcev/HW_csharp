/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Массив случайных 8ми элементов:"); 

int array_length = 8;
int[] array = new int[array_length];
Random random = new Random();

for (int i = 0; i < array_length; i++)
{
    array[i] = random.Next(1, 41); // (диапазон чисел для наглядности)
}

Console.Write("[");
for (int j = 0; j < array.Length - 1; j++)
{
    Console.Write($"{array[j]}, ");
}
Console.Write(array[array.Length - 1]);
Console.Write("]");
