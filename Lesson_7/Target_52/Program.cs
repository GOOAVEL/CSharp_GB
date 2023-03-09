/* Задача 52.
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] Generate2DArray(int countArray, int countEl, int start, int end)
{
    int[,] array2D = new int[countArray, countEl];

    for (int i = 0; i < array2D.GetLength(0); i++)
        for (int j = 0; j < array2D.GetLength(1); j++)
            array2D[i, j] = new Random().Next(start, end + 1);

    return array2D;
}

void Show2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write($"[{array2D[i, j]}]");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowAverageEl(int[,] array2D)
{
    double[] average = new double[array2D.GetLength(1)];

    int i = 0;
    for (; i < array2D.GetLength(0); i++)
        for (int j = 0; j < array2D.GetLength(1); j++)
            average[j] += (double)array2D[i, j];

    for (int c = 0; c < average.Length; c++)
        average[c] = Math.Round(average[c] / i, 1);

    Console.Write("Arithmetic mean of each column: ");
    foreach (var item in average)
        Console.Write($"{item}; ");
}


int[,] twoDArray = Generate2DArray(3, 4, 1, 9);
Show2DArray(twoDArray);

ShowAverageEl(twoDArray);