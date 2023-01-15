﻿Console.Write("Укажите колличество элементов массива: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(b);
Console.WriteLine($" [ {String.Join(" , ", array)} ] ");


int[] GetArray(int size)

{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 33 + 1);
    }

    return result;
}
