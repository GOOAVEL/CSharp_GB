/* Задача 4:
Напишите программу, которая принимает на вход три числа и выдаёт
максимальное из этих чисел.*/

System.Console.Write("Enter first number: ");
int a = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Enter second number: ");
int b = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Enter third number: ");
int c = Convert.ToInt32(System.Console.ReadLine());

if (c > Math.Max(a, b)) System.Console.WriteLine(c);
else System.Console.WriteLine(Math.Max(a, b));