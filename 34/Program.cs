// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int len = 10;
int [] arr = new int [len];

void FillArray (int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(100, 1000);
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

int EvenNumbers(int[] array)
{
    int evens = 0;
    for(int i = 0; i < len; i++)
    {
        if(array[i] % 2 == 0) evens += 1;
    }
    return evens;
}

FillArray(arr);
Console.Write("Дан массив: ");
PrintArray(arr);
Console.WriteLine();
Console.Write($"Количество четных чисел в массиве = {EvenNumbers(arr)}");