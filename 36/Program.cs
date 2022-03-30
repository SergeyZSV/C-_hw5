// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int len = 10;
int[] arr = new int[len];

void FillArray (int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(1, 101);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < len; i++)
    {
        Console.Write(array[i]);
        if(i < len - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
}

int SumOdds(int[] array)
{
    int sum = 0;
    for(int i = 0; i < len; i++)
    {
        if(i % 2 != 0) sum += array[i];
    }
    return sum;
}

FillArray(arr);
Console.WriteLine("");
Console.Write("Дан массив: ");
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях массива = {SumOdds(arr)}");
Console.WriteLine("");
