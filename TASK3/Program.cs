Console.Write("Укажите колличество элементов массива: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] array = GetBinaryArray(b);
Console.WriteLine($" [ {String.Join(" , ", array)} ] ");


int[] GetBinaryArray(int size) // GetBinaryArray - это просто название функции

{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(19);
    }

    return result;
}
