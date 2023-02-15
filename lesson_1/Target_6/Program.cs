/* Задача 6:
Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).*/


System.Console.Write("Please enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) System.Console.WriteLine("The number " + a + " is even");
else Console.WriteLine("The number " + a + " is odd");


// TODO: Dictionary:
//? 1. even - четное
//? 2. odd - нечетное