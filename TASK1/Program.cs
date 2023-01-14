// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int function(int x, int y)
{
    int result = 0;
    for (int count = 1; count < y; count++)
    {
        if (count == 1)
        {
            result = x * x;
        }
        else
        {
            result = result * x;
        }

    }
    return result;
}

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {a} в степени {b} равно: {function(a, b)}");