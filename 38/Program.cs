// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int len = 10;
double[] arr = new double[len];

void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < len; i++)
    {
        Console.Write(array[i]);
        if (i < len - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
}

double Max(double[] array)
{
    int max = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] > array[max]) max = i;
    }
    return array[max];
}

double Min(double[] array)
{
    int min = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] < array[min]) min = i;
    }
    return array[min];
}

FillArray(arr);
Console.WriteLine();
Console.Write("Дан массив вещественных чисел: ");
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным элементом {Max(arr)} и минимальным элементом {Min(arr)} = {Max(arr) - Min(arr)}");
Console.WriteLine();