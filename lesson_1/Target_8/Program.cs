/* Задача 8:
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N..*/

System.Console.Write("Alexandr please enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    if (i % 2 == 0) System.Console.WriteLine(i);
}