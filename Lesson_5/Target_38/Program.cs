/*Задача 38:
 Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.*/

double[] GetRandomIntArray(int size, int end, int round)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * end, round);

    return array;
}

void ShowArray(double[] array)
{
    foreach (var item in array)
        Console.Write($"[{item}] ");
}

double DiffBetweenMaxAndMinElsOfArray(double[] array)
{
    double max = array[0], min = max;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }

    return max - min;
}


double[] array = GetRandomIntArray(10, 3, 1);
ShowArray(array);
System.Console.WriteLine();

System.Console.WriteLine("Differnce bettwen max and min of array: "
+ Math.Round(DiffBetweenMaxAndMinElsOfArray(array), 2));

