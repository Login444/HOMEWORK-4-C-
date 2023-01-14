// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int summa (int number)
{
    int sum = 0;
    int fig = 0;
    while (number >0)
    {
        fig = number % 10;
        number = number / 10;
        sum = sum + fig;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр числа {num} равна {summa(num)}");