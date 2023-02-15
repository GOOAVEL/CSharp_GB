/* Задача 2:
Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее. */

System.Console.Write("Enter first number: ");
int a = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Enter second number: ");
int b = Convert.ToInt32(System.Console.ReadLine());

if (b > a) { int c = a; a = b; b = c; }

System.Console.WriteLine("Number " + a + " is BIG");
System.Console.WriteLine("And the number " + b + " is LARGE");
