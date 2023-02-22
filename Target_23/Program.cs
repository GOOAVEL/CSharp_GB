/*Задача 23:
 Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.*/

while (true)
{
    Console.Write("Enter a only number: ");
    int x = Convert.ToInt32(System.Console.ReadLine());
    if (x < 0) Console.WriteLine("The number must be greater than zero");
    else for (int i = 1; i <= x;)
        {
            Console.Write((i * i * i++) + $"({i - 1}*{i - 1}*{i - 1}) ");
            break;
        }
}