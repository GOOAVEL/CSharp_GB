/*Задача 27:
 Напишите программу, которая принимает на вход число и
 выдаёт сумму цифр в числе.*/

Console.Write("Enter any number: ");
string userNumberStr = Console.ReadLine();

GetSumAllDigits(userNumberStr);

void GetSumAllDigits(string digitsStr)
{
    bool isNumber = Int32.TryParse(userNumberStr, out int userNumber);
    if (isNumber)
    {
        int sum = 0;
        int copyNum = userNumber;
        while (userNumber != 0)
        {
            sum += userNumber % 10;
            userNumber /= 10;
        }
        Console.WriteLine($"Sum all digits the number {copyNum}: {sum}");
    }
    else Console.WriteLine("This is not a number!");
}