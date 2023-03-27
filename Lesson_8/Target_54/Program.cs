/*Задача 54:
 Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
 Например, задан массив:    
 1 4 7 2
 5 9 2 3
 8 4 2 4
 В итоге получается вот такой массив:
 7 4 2 1
 9 5 3 2
 8 4 4 2    */

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
            System.Console.Write($"[{array[i, j]}] ");
        System.Console.WriteLine();
    }
}

void SortEveryArray(int[,] array2D)
{
    int[] array1 = new int[array2D.GetLength(1)];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            array1[j] = array2D[i, j];

        Array.Sort(array1);
        Array.Reverse(array1);

        for (int j = 0; j < array2D.GetLength(1); j++)
            array2D[i, j] = array1[j];
    }
}

int[,] array = Create2DArray(4, 4, 9);
Show2DArray(array);
Console.WriteLine();
SortEveryArray(array);
Show2DArray(array);
