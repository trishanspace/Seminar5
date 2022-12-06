// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] array = GenerateArray(100, 999, 10);
PrintArray(array);
int NumberOfEvenNumbers = GetNumberOfEvenNumbers(array);

void PrintArray(int[] array)
{
        Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.WriteLine($"Количество четных чисел = {NumberOfEvenNumbers}.");

int GetNumberOfEvenNumbers(int[] array)
{
    int NumberOfEvenNumbers = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            NumberOfEvenNumbers = NumberOfEvenNumbers+1;
        }
    }

    return NumberOfEvenNumbers;
}

int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}