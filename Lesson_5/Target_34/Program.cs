/*Задача 34:
 Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.*/

int[] GetRandomIntArray(int size, int start, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(start, end + 1);

    return array;
}

void ShowArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"[{item}] ");
}

int GetCountEvenNumbersOfArray(int[] array)
{
    int count = 0;
    foreach (var item in array)
        if (item % 2 == 0) count++;

    return count;
}

int[] array = GetRandomIntArray(10, 100, 999);
ShowArray(array);
Console.WriteLine();

Console.WriteLine(GetCountEvenNumbersOfArray(array));
