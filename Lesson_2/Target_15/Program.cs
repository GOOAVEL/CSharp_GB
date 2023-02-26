/* Задача 15:
 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.*/


System.Console.Write("Enter the day of the week in the format of digit: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(
    a > 0 && a < 6 ? "Working day" :
    a > 5 && a < 8 ? "The day is OFF" : "Invalid"
);