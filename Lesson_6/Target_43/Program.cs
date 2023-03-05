/* Задача 43:
 Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)                     */

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FindPointOfEquation(int[,] array)
{
    int b1 = array[0, 0],
        k1 = array[0, 1],
        b2 = array[1, 0],
        k2 = array[0, 1];

    double x()
    {
        var result = (double)b2 - b1 / k1 - k2;
        return result;
    }

    double y()
    {
        var result = (double)k1 * x() + b1;
        return result;
    }

    Console.WriteLine($"x = {x()} y = {y()}");
}


string[] nnAr = { "first", "second" };
string[] nn2Ar = { "b1", "k1", "b2", "k2" };
int[,] points = new int[2, 2];

for (int i = 0, c = 0; i < points.GetLength(0); i++, c++)
{
    for (int j = 0; j < points.GetLength(1); j++, c++)
    {
        points[i, j] = Prompt($"Enter {nnAr[j]} value for {nnAr[i]} point: ");
        System.Console.WriteLine($"{nn2Ar[c]} = {points[i, j]}");
    }
}

FindPointOfEquation(points);
