// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = GenerateArray(10, 100, 5);
PrintArray(array);
int min = GetMinValue(array);
int max = GetMaxValue(array);
int diff = GetDifferenceOfExtremeNumbers(array.Length);


void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}.");

int GetMinValue(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
    }
    return min;
}
int GetMaxValue(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int GetDifferenceOfExtremeNumbers(int diff)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i <= array.Length)
            diff = max - min;

    }
    return diff;
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