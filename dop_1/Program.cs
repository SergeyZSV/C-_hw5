// Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число. Напишите программу, которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.
// {0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
// {4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет

int len = 15;
int[] array = new int[len];

Console.WriteLine();

FillArray(array);
Console.Write("Дан массив: [ ");
PrintArray(array);
Console.Write(" ]");
Console.WriteLine();
Console.Write("Введите число для поиска: ");

int number = Convert.ToInt32(Console.ReadLine());
int a = number / 100;
int b = number / 10 % 10;
int c = number % 10;

if(Elemens(number, array) == 1)
{
    Console.WriteLine($"Число {number} присутствует в массиве.");
}
else Console.WriteLine($"Число {number} не присутствует в массиве.");

Console.WriteLine();


void FillArray (int[] array)
{
    Random rand = new Random();
    for(int i = 0; i < len; i++)
    {
        array[i] = rand.Next(1, 10);
        // array [i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray (int[] array)
{
    for(int i = 0; i < len; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int Elemens(int number, int[] array)
{
    string number_str = Convert.ToString(number);
    int result = 0;
    for(int i = 0; i < len - 2; i++)
    {
        if(array[i] == a & array[i + 1] == b & array[i + 2] == c)
        {
            result = 1; 
        } 
        if (result == 1) break;

    }
    return result;
}


