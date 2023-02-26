/*Задача 25:
 Напишите цикл, который принимает на вход два числа (A и B) и
 возводит число A в натуральную степень B.*/

int GetDegreeOfNumber(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++) result *= a;
    return result;
}

System.Console.WriteLine(GetDegreeOfNumber(2, 1));