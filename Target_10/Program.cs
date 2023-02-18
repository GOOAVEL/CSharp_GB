/* Задача 10:
 Напишите программу, которая принимает на вход трёхзначное число и на выходе
 показывает вторую цифру этого числа.*/

System.Console.WriteLine("Enter the terehitum number");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 && a < 1000) Console.WriteLine((a % 100) / 10);
else Console.WriteLine("Invalid, enter the terehitum number!");