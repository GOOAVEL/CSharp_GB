﻿/*Задача 19:
 Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.*/

while (true)
{
    Console.Write("Enter the five-digit number: ");
    string numberStr = Console.ReadLine();
    if (numberStr.Length == 5)
        if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
        {
            Console.WriteLine("YES!, The number is palindrome!");
            break;
        }
        else
        {
            Console.WriteLine("Sorry, The number is palindrome!");
            break;
        }
}