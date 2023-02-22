/*Задача 21:
 Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.*/

int[] firstPoint = new int[3], secondPoint = new int[3];

void FillArray(int[] array)
{
    string[] words = { "first", "second", "third" };
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array == secondPoint) j = 1;
        Console.Write($"Enter the {words[i]} number for the {words[j]} point: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

FillArray(firstPoint);
FillArray(secondPoint);

double operation_1 = Math.Pow(secondPoint[0] - firstPoint[0], 2);
double operation_2 = Math.Pow(secondPoint[1] - firstPoint[1], 2);
double operation_3 = Math.Pow(secondPoint[2] - firstPoint[2], 2);
double result = Math.Round(Math.Sqrt(operation_1 + operation_2 + operation_3), 2);

Console.WriteLine($"The length between first points and second points is {result}");