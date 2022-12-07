// Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GenerateArray(-100, 100, 5);
PrintArray(array);
int sumElements = GetSumOfElementsOnOddIndexes(array);

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах равна {sumElements}.");

int GetSumOfElementsOnOddIndexes(int[] array)
{
    int sumElements = 0;
    for (var i = 1; i < array.Length; i +=2)
    {
        if (array[i] > 0)
        {
            sumElements += array[i];
        }
    }

    return sumElements;
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