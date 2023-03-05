/* Задача 41:
 Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3                     */

Console.WriteLine("This program counts how many numbers more zero you have entered");
InputCounter();

void InputCounter()
{
    int count = 0;
    Console.Write("Enter numbers to console: ");

    string numsStr = Console.ReadLine();
    string[] StrArr = numsStr.Split(" ");

    for (int i = 0; i < StrArr.Length; i++)
    {
        bool isNumber = Int32.TryParse(StrArr[i], out int a);

        if (isNumber && a > 0) count++;
    }

    Console.WriteLine(count);
}