/*Задача 36:
 Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.*/

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

int GetSumOddElementsOfArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0)
            sum += array[i];

    return sum;
}

int[] array = GetRandomIntArray(5, 0, 15);
ShowArray(array);
Console.WriteLine();

Console.WriteLine(GetSumOddElementsOfArray(array));
