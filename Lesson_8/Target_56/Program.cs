/*Задача 56:
 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 Например, задан массив:

 1 4 7 2
 5 9 2 3
 8 4 2 4
 5 2 6 7

 Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка    */

int[,] Create2DArray(int countArr, int countEl, int to)
{
    int[,] array = new int[countArr, countEl];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, to + 1);

    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"[{array[i, j]}]");
        Console.WriteLine();
    }
}

void FIndSmallSumArr(int[,] array2D)
{
    int[] temp = new int[array2D.GetLength(1)];
    int[] sums = new int[array2D.GetLength(0)];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            temp[j] = array2D[i, j];

        sums[i] = temp.Sum();
    }

    int minIdx = GetMinIndexToArray(sums);

    Console.WriteLine($"{minIdx + 1} строка является наименьшей");
}

int GetMinIndexToArray(int[] array)
{
    int min = array[0];
    int Idx = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
        {
            min = array[i];
            Idx = i;
        }

    return Idx;
}

int[,] array2D = Create2DArray(4, 4, 9);
Show2DArray(array2D);
Console.WriteLine();
FIndSmallSumArr(array2D);