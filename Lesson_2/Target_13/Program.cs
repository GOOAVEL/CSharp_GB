/* Задача 13:
 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.*/


System.Console.Write("Enter any three digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

// вариант если третья цифра с начала
if (a < 100) Console.WriteLine("The number does not have a third digit");
else if (a < 1000) Console.WriteLine(a % 10);
else
{
    for (; a > 1000; a = a / 10) { }
    Console.WriteLine(a % 10);
}

// вариант если третья цифра с конца
// if (a < 100) Console.WriteLine("The number does not have a third digit");
// else if (a / 100 > 10) Console.WriteLine((a / 100) % 10);
// else Console.WriteLine((a / 100));

